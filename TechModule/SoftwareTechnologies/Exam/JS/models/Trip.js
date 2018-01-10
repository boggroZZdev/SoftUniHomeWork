const mongoose = require('mongoose');

let tripSchema = mongoose.Schema({
    origin: {type: "string", required:true, minlength: 1},
    destination: {type: "string", required:true, minlength: 1},
    business: {type: "Number", required:true},
    economy: {type: "Number", required:true},
});

let Trip = mongoose.model('Trip', tripSchema);

module.exports = Trip;