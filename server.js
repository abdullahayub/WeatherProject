var express = require('express');
var app = express();

var path     = require('path');
var port     = process.env.PORT || 8080;
var mongoose = require('mongoose');
var bodyParser = require('body-parser');
var passport = require('passport');
var session = require('express-session');
var cookieParser = require('cookie-parser');