$(function () {
    getWriters()
})

function getWriters() {
    fetch("/api/Writers/")
        .then(data => data.json())
        .then(data => displayWriters(data))
}

function getBooks(event, id) {
    selectLine(event.target.parentNode)

    var apiEndpoint = "/api/Writers/" + id + "/Books"
    fetch(apiEndpoint)
        .then(data => data.json())
        .then(data => displayBooks(data))
}

function displayBooks(data) {
    var tbody = document.querySelector('#table-books')
    tbody.innerHTML = data.map(item =>
        `<tr>
            <td>${item.title}</td>
            <td>${item.year}</td>
        </tr>`
    ).join('')
}

function displayWriters(data) {
    var tbody = document.querySelector('#table-writers')
    tbody.innerHTML = data.map(item =>
        `<tr onclick="getBooks(event, ${item.id})">
            <td>${item.name}</td>
            <td>${formatDate(item.dateOfBirth)}</td>
        </tr>`
    ).join('')
}

function formatDate(d) {
    return d.substring(0, 10)
}

function selectLine(node) {
    var lines = document.querySelectorAll("#table-writers tr")
    lines.forEach(line => line.className = '')
    node.className = "bg-primary"
}
