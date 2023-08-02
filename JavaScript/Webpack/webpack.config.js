const modoDev = process.env.node_env !== "production"
const web = require('webpack')
const MiniCssExtractPlugin = require("mini-css-extract-plugin");
const TerserPlugin = require('terser-webpack-plugin')
const OptimizeCSSAssetsPlugin = require('css-minimizer-webpack-plugin')


module.exports = {
    mode: modoDev ? 'development' : 'production',
    entry: './src/principal.js',
    output: {
        filename: 'principal.js',
        path: __dirname + '/public',
    },
    devServer: {
        //contentBase: "./public",
        
        port: 9000
    },
    optimization: {
        minimizer: [
            new OptimizeCSSAssetsPlugin({}),
        ]
    },
    plugins: [
        new TerserPlugin({
            parallel: true,
            terserOptions: {
                ecma: 6,
            },
        }),
        new MiniCssExtractPlugin({
            filename: "estilo.css"
        })
    ],
    module: {
        rules: [{
            test: /\.s?[ac]ss$/, //expressao regular
            use: [
                MiniCssExtractPlugin.loader,
                //'style-loader', //Adiciona o CSS e DOM injetando a tag <style>
                'css-loader',
                'sass-loader',
            ]
        }, {
            test: /\.(png|svg|jpg|gif)$/,
            use: [{
                loader: 'file-loader'
            }]
        }]
    }
}