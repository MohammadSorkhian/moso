const request = require("request")
const url = "https://api.mapbox.com/geocoding/v5/mapbox.places/iran.json?access_token=pk.eyJ1IjoibW9oYW1tYWRzIiwiYSI6ImNraDg1cTRxbjBmbDgycWsxbG53Nm4xMDkifQ.Ev2emNflYeCtMTB4sSQyQg&limit=1";
request({url:url, json:true}, (error, response) => {
        if (error) {
            console.log("sorry there is a wierd error!!!")}
            else if(response.body.features.length === 0){
                console.log("sorry you provided a wrong location : "+ response.body.query[0])}
            else{
        const logtitude = response.body.features[0].center[0]
        const latitude = response.body.features[0].center[1]
        console.log(latitude)
        console.log(logtitude)
            }
    })