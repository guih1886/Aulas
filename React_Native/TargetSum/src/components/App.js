import React, { Component } from 'react'

import { View, Text, StyleSheet } from 'react-native'

export default class App extends Component {
    render() {
        return (
            <View style={styles.container}>
                <Text>Hello</Text>
            </View>
        )
    }
}

const styles = StyleSheet.create({
    container: {
        backgroundColor: 'gray',
        flex: 1
    },
})
