import React, { Component } from 'react'
import { View, Text, StyleSheet } from 'react-native'
import ajax from '../ajax'
import DealDetail from './DealDetail'
import DealsList from './DealsList'

export default class App extends Component {
    state = {
        deals: [],
        currentDealId: null,
    }
    async componentDidMount() {
        const deal = await ajax.fetchInitialDeals()
        this.setState({ deals: deal })
    }
    setCurrentDeal = (dealId) => {
        this.setState({ currentDealId: dealId })
    }
    unsetCurrentDeal = () => {
        this.setState({ currentDealId: null })
    }
    currentDeal = () => {
        return this.state.deals.find((deal) => {
            deal.key === this.state.currentDealId
        })
    }
    render() {
        if (this.state.currentDealId) {
            return <DealDetail initialDealData={this.currentDeal()} onBack={this.unsetCurrentDeal}/>
        }
        if (this.state.deals.length > 0) {
            return <DealsList deals={this.state.deals} onItemPress={this.setCurrentDeal}></DealsList>
        }
        return (
            <View style={styles.container}>
                {
                    <Text style={styles.header}>Bakesale</Text>
                }
            </View>
        )
    }
}
const styles = StyleSheet.create({
    container: {
        flex: 1,
        alignItems: 'center',
        justifyContent: 'center',
    },
    header: {
        fontSize: 40,
    }
})
