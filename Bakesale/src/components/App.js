import React, { Component } from 'react'
import { View, Text, StyleSheet } from 'react-native'
import ajax from '../ajax'
import DealDetail from './DealDetail'
import DealsList from './DealsList'
import SearchBar from './SearchBar'

export default class App extends Component {
    state = {
        deals: [],
        dealsFormSearch: [],
        currentDealId: null,
    }
    async componentDidMount() {
        const deals = await ajax.fetchInitialDeals()
        this.setState({ deals })
    }
    searchDeals = async (searchTerm) => {
        let dealsFormSearch = []
        if(searchTerm){
            dealsFormSearch = await ajax.fetchDealSearchResult(searchTerm)
        } else {
            dealsFormSearch = []
        }
        this.setState({ dealsFormSearch });
    }
    /*clearSearch = () => {
        this.setState({ dealsFormSearch: [] })
    }*/
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
            return (
                <View style={styles.main}>
                    <DealDetail initialDealData={this.currentDeal} onBack={this.unsetCurrentDeal} />
                </View>
            )
        }
        const dealsToDisplay = this.state.dealsFormSearch.length > 0 ? this.state.dealsFormSearch : this.state.deals
        if (dealsToDisplay.length > 0) {
            return (
                <View style={styles.main}>
                    <SearchBar searchDeals={this.searchDeals}/>
                    <DealsList deals={dealsToDisplay} onItemPress={this.setCurrentDeal} />
                </View>
            )
        }
        return (
            <View style={styles.container}>
                <Text style={styles.header}>Bakesale</Text>
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
    },
    main: {
        marginTop: 10
    }
})
