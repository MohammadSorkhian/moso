const path = require("path")
const express = require("express")
const app = express()

const publicDirectoryPath = path.join(__dirname, "../public")

app.use(express.static(publicDirectoryPath))

// app.get('', (req, res)=>{
//     res.send("Hi Mohammad you can hit it")
// })

app.get("/help", (req,res)=>{
    res.send(
        [{name:"moso",
        age:"34"}]
    )
})

// app.get("/about", (req,res)=>{
//     res.send("<h1>about section</h1>")
// })

app.get("/weather", (req,res)=>{
    res.send("weather section")
})

const port = process.env.port || 3000
app.listen(3000, ()=>{
    console.log("server is up and running")
})




