module.exports = function (app){
    app.get('/',function(req,res){
        res.render('index.ejs');
    });
    app.get('/checkout',function(req,res){
        res.render('checkout.ejs');
    });
    app.get('/logout', function (req, res) {
        req.logout();
        res.redirect('/');
    });
    app.get('/about-us', function (req, res) {
        res.render('about-us.ejs');
    });
    app.get('/we', function (req, res) {
        res.render('we.ejs');
    });
    app.get('/test', function (req, res) {
        res.render('font.ejs');
    });
};