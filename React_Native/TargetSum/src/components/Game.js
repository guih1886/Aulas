import React, { Component } from 'react'
import { View, Text, StyleSheet } from 'react-native'
import PropTypes from 'prop-types'
import RandomNumber from './RandomNumber'

export default class Game extends Component {
    static propTypes = {
        randomNumberCount: PropTypes.number.isRequired
    }
    state = {
        selectedNumbers: [],
    }
    //define the quantity of numbers for the sum
    randomNumbers = Array.from({ length: this.props.randomNumberCount }).map(() => 1 + Math.floor(10 * Math.random()))
    target = this.randomNumbers.slice(0, this.props.randomNumberCount - 2).reduce((acc, curr) => acc + curr, 0)
    isNumberSelected = (numberIndex) => {
        return this.state.selectedNumbers.indexOf(numberIndex) >= 0
    }
    selectNumber = (numberIndex) => {
        this.setState((prevState) => ({
            selectedNumbers: [...prevState.selectedNumbers, numberIndex]
        }))
    }
    render() {
        return (
            <View style={styles.container}>
                <Text style={styles.target}>{this.target}</Text>
                <View style={styles.randomContainer}>
                    {this.randomNumbers.map((randomNumber, index) =>
                        <RandomNumber key={index} id={index} number={randomNumber} isDisabled={this.isNumberSelected(index)} onPress={this.selectNumber}/>)
                    }
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
        textAlign: 'center',
        marginBottom: 50
    },
    randomContainer: {
        flexDirection: 'row',
        flexWrap: 'wrap',
        flex: 1,
        justifyContent: 'space-around'
    },
})
