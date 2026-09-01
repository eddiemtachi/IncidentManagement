window.incidentCharts = {
    init: function () {
        new Chart(document.getElementById("incidentByType"), {
            type: 'pie',
            data: {
                labels: ["Fire", "Medical", "Security", "Other"],
                datasets: [{
                    data: [14, 9, 32, 6],
                    backgroundColor: ["#ff6384", "#36a2eb", "#ffcd56", "#4bc0c0"]
                }]
            },
            options: {
                responsive: true,
                maintainAspectRatio: false,
                plugins: {
                    title: { display: true, text: "Incidents by Type", font: { size: 18 } },
                    legend: { position: 'bottom', labels: { font: { size: 14 }, color: '#333' } },
                    tooltip: { enabled: true, bodyFont: { size: 14 }, titleFont: { size: 15 } }
                }
            }
        });

        new Chart(document.getElementById("incidentByMonth"), {
            type: 'bar',
            data: {
                labels: ["Jan", "Feb", "Mar", "Apr", "May", "Jun"],
                datasets: [{
                    label: "Incidents",
                    data: [12, 18, 15, 22, 19, 25],
                    backgroundColor: "#36a2eb"
                }]
            },
            options: {
                responsive: true,
                maintainAspectRatio: false,
                plugins: {
                    title: { display: true, text: "Incidents per Month", font: { size: 18 } },
                    legend: { display: false },
                    tooltip: { enabled: true, bodyFont: { size: 14 }, titleFont: { size: 15 } }
                },
                scales: {
                    y: { ticks: { font: { size: 14 }, color: '#333' }, title: { display: true, text: "Number of Incidents" } },
                    x: { ticks: { font: { size: 14 }, color: '#333' }, title: { display: true, text: "Month" } }
                }
            }
        });

        new Chart(document.getElementById("incidentSeverity"), {
            type: 'doughnut',
            data: {
                labels: ["Low", "Medium", "High", "Critical"],
                datasets: [{
                    data: [20, 25, 15, 5],
                    backgroundColor: ["#4bc0c0", "#ffcd56", "#ff9f40", "#ff6384"]
                }]
            },
            options: {
                responsive: true,
                maintainAspectRatio: false,
                plugins: {
                    title: { display: true, text: "Severity Levels", font: { size: 18 } },
                    legend: { position: 'bottom', labels: { font: { size: 14 }, color: '#333' } },
                    tooltip: { enabled: true, bodyFont: { size: 14 }, titleFont: { size: 15 } }
                }
            }
        });

        new Chart(document.getElementById("incidentResolution"), {
            type: 'line',
            data: {
                labels: ["Week 1", "Week 2", "Week 3", "Week 4"],
                datasets: [{
                    label: "Resolved",
                    data: [3, 8, 12, 18],
                    borderColor: "#4bc0c0",
                    fill: false,
                    tension: 0.3
                }]
            },
            options: {
                responsive: true,
                maintainAspectRatio: false,
                plugins: {
                    title: { display: true, text: "Resolution Progress", font: { size: 18 } },
                    legend: { position: 'bottom', labels: { font: { size: 14 }, color: '#333' } },
                    tooltip: { enabled: true, bodyFont: { size: 14 }, titleFont: { size: 15 } }
                },
                scales: {
                    y: { ticks: { font: { size: 14 }, color: '#333' }, title: { display: true, text: "Resolved Cases" } },
                    x: { ticks: { font: { size: 14 }, color: '#333' }, title: { display: true, text: "Week" } }
                }
            }
        });

        new Chart(document.getElementById("incidentLocation"), {
            type: 'bar',
            data: {
                labels: ["Gate A", "Gate B", "Parking", "Office"],
                datasets: [{
                    label: "Incidents",
                    data: [10, 7, 15, 6],
                    backgroundColor: "#ff9f40"
                }]
            },
            options: {
                responsive: true,
                maintainAspectRatio: false,
                plugins: {
                    title: { display: true, text: "Incidents by Location", font: { size: 18 } },
                    legend: { display: false },
                    tooltip: { enabled: true, bodyFont: { size: 14 }, titleFont: { size: 15 } }
                },
                scales: {
                    y: { ticks: { font: { size: 14 }, color: '#333' }, title: { display: true, text: "Number of Incidents" } },
                    x: { ticks: { font: { size: 14 }, color: '#333' }, title: { display: true, text: "Location" } }
                }
            }
        });

        new Chart(document.getElementById("incidentTrend"), {
            type: 'line',
            data: {
                labels: ["Feb", "Mar", "Apr", "May", "Jun", "Jul"],
                datasets: [{
                    label: "Total Incidents",
                    data: [15, 20, 18, 25, 28, 30],
                    borderColor: "#36a2eb",
                    fill: false,
                    tension: 0.3
                }]
            },
            options: {
                responsive: true,
                maintainAspectRatio: false,
                plugins: {
                    title: { display: true, text: "Incident Trend (6 Months)", font: { size: 18 } },
                    legend: { position: 'bottom', labels: { font: { size: 14 }, color: '#333' } },
                    tooltip: { enabled: true, bodyFont: { size: 14 }, titleFont: { size: 15 } }
                },
                scales: {
                    y: { ticks: { font: { size: 14 }, color: '#333' }, title: { display: true, text: "Number of Incidents" } },
                    x: { ticks: { font: { size: 14 }, color: '#333' }, title: { display: true, text: "Month" } }
                }
            }
        });
    }
};
