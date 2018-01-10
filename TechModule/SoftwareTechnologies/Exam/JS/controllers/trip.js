const Trip = require('../models/Trip');

module.exports = {
    index: (req, res) => {
        Trip.find().then(trips => {
            return res.render('trip/index', {'trips' : trips});
        })
    },
    createGet: (req, res) => {
        res.render('trip/create');
    },
    createPost: (req, res) => {
        let trip = req.body;
        Trip.create(trip).then(trip => {
            "use strict";
            res.redirect("/");
        })
    },
    editGet: (req, res) => {
        let tripId = req.params.id;
        Trip.findById(tripId).then(trip => {
            "use strict";
            if (trip){
                res.render('trip/edit', trip);
            }
            else{
                res.redirect('/');
            }
        })
    },
    editPost: (req, res) => {
        let tripId = req.params.id;
        let trip = req.body;

        Trip.findByIdAndUpdate(tripId, trip).then(
            trip=> {
                "use strict";
                res.redirect('/');
            }
        )
    },
    deleteGet: (req, res) => {
        let id = req.params.id;
        Trip.findById(id).then(trip => {
            "use strict";
            if (trip){
                return res.render('trip/delete', trip);
            } else{
                return res.redirect('/');
            }
        })
    },
    deletePost: (req, res) => {
        let id = req.params.id;
        Trip.findByIdAndRemove(id).then(data=> {
            "use strict";
            res.redirect('/');
        })
    }
};