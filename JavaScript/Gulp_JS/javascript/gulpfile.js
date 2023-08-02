const { series } = require("gulp")
const gulp = require("gulp")
const concat = require("gulp-concat")
const uglify = require("gulp-uglify")
const babel = require("gulp-babel")

function padrao(cb) {
    gulp.src("src/**/*.js")
        .pipe(babel({
            comments: false,
            presets: ["@babel/env"]
        })).pipe(uglify())
        .pipe(concat("codigo.min.js"))
        .pipe(gulp.dest("build"))
    return cb()
}

module.exports.default = series(padrao)

