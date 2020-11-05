const express  = require("express");

const app = express();

// Middleware for logging incoming requests and erros
// app.use((req, res, next)=>{
//     console.log(`Request method: ${req.method}`, "*********", `Request URL: ${req.originalUrl}`);
//     next();
// });
// app.use(express.static(path.join(__dirname,"public")));

// app.get('/error',(req,res) =>{
//     throw new Error ("error!")
// });

// app.use((req,res)=>{
//     res.status(404).send(`<h1>Sorry, path not found ${req.method} at ${req.originalUrl}</h1>`);
// })

// // End of middlewares

// app.use((err, req, res, next) => {
//     res.status(500).send(`<h1> Sorry, error ${err}</h1>`)
// })

app.get('/',(req,res) =>{
    res.send('Hello world! This is test app for friendship app');
});



app.listen(3000, () => {
  console.log("Server running at port 3000");
});