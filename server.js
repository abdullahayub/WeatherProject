var express = require('express');
var app = express();

var path     = require('path');
var port     = process.env.PORT || 8080;
var mongoose = require('mongoose');
var bodyParser = require('body-parser');
var passport = require('passport');
var session = require('express-session');
var cookieParser = require('cookie-parser');
//setting public side and setting engines
app.set('view-engine', '.ejs');
app.set('views', 'src/views');
app.use(express.static(path.join(__dirname, 'public')));