var mongoose = require('mongoose');
var bcrypt = require('bcrypt-nodejs');
// define the schema for our user model
var traineeSchema = mongoose.Schema({
    FirstName: String,
    LastName: String,
    UserName:String,
    email: String,
    password: String,
    points: Number,
    check: Number // admin gets 0, trainer gets 1, trainee gets 2 so that the routes are accessible
    // according to the user type.
});

traineeSchema.methods.generateHash = function (password) {
    return bcrypt.hashSync(password, bcrypt.genSaltSync(8), null);
};

traineeSchema.methods.validPassword = function (password) {
    return bcrypt.compareSync(password, this.password);
};

module.exports = mongoose.model('Trainee', traineeSchema);