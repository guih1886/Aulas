import React, { Component } from 'react'
import { View, Text, StyleSheet } from 'react-native'
import PropTypes from 'prop-types'

export default class Game extends Component {
    static propTypes = {
        randomNumberCount: PropTypes.number.isRequired
    }
    //define the quandidy of numbers for the sum
    randomNumbers = Array.from({ length: this.props.randomNumberCount }).map(() => 1 + Math.floor(10 * Math.random()))

    target = this.randomNumbers.slice(0, this.props.randomNumberCount - 2).reduce((acc, curr) => acc + curr, 0)

    render() {
        return (
            <View style={styles.container}>
                <Text style={styles.target}>{this.target}</Text>
                <View style={styles.randomContainer}>
                    {this.randomNumbers.map((randomNumber, index) => <Text style={styles.random} key={index}>{randomNumber}</Text>)}
                </View>
            </View>
        )
    }
}

const styles = StyleSheet.create({
    container: {
        backgroundColor: 'orange',
        flex: 1,
        paddingTop: 30
    },
    target: {
        fontSize: 40,
        color: '#fff',
        backgroundColor: 'gray',
        marginHorizontal: 50,
        textAlign: 'center'
    },
    randomContainer: {
        backgroundColor: '#444',
        flexDirection: 'row'
        
    },
    random: {

    }
})
