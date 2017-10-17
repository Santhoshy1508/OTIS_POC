//-----------------sidebar----------------------------

$(document).ready(function () {

    $.sidebarMenu($('.sidebar-menu'))
    $.sidebarMenu($('.sidebar-menu-rtl'))

});

//-------------Chartjs-------------------
$(document).ready(function () {

    var ctx = document.getElementById("contracts-chart");
    var myChart = new Chart(ctx, {
        type: 'bar',
        data: {
            labels: ["June", "July", "Aug", "Sept", "Oct"],
            datasets: [{
                label: 'Contracts',
                data: [19, 3, 5, 2, 3],
                backgroundColor: [
                    'rgba(54, 162, 235, 1)',
                    'rgba(255, 206, 86, 1)',
                    'rgba(75, 192, 192, 1)',
                    'rgba(153, 102, 255, 1)',
                    'rgba(255, 159, 64, 1)'
                ]//],
                //borderColor: [
                //    'rgba(54, 162, 235, 1)',
                //    'rgba(255, 206, 86, 1)',
                //    'rgba(75, 192, 192, 1)',
                //    'rgba(153, 102, 255, 1)',
                //    'rgba(255, 159, 64, 1)'
                //],
                //borderWidth: 1
            }]
        },
        options: {
            scales: {
                yAxes: [{
                    ticks: {
                        beginAtZero:true
                    }
                }]
            }
        }
    });

    var ctx = document.getElementById("payments-chart");
    var myChart = new Chart(ctx, {
        type: 'bar',
        data: {
            labels: ["June", "July", "Aug", "Sept", "Oct"],
            datasets: [{
                label: 'Payments',
                data: [53, 14, 25, 12, 23],
                backgroundColor: [
                    'rgba(54, 162, 235, 1)',
                    'rgba(255, 206, 86, 1)',
                    'rgba(75, 192, 192, 1)',
                    'rgba(153, 102, 255, 1)',
                    'rgba(255, 159, 64, 1)'
                ],
                //borderColor: [
                //    'rgba(241, 9, 42, 1)',
                //    'rgba(255, 206, 86, 1)',
                //    'rgba(75, 192, 192, 1)',
                //    'rgba(153, 102, 255, 1)',
                //    'rgba(255, 159, 64, 1)'
                //],
                borderWidth: 1
            }]
        },
        options: {
            scales: {
                yAxes: [{
                    ticks: {
                        beginAtZero: true
                    }
                }]
            }
        }
    });

});