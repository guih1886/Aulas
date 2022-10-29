import React, { Component } from 'react'
import { TextInput, StyleSheet } from 'react-native'
import PropTypes from 'prop-types'
import debounce from 'lodash.debounce'

export default class SearchBar extends Component {
    static propTypes = {
        searchDeals: PropTypes.func.isRequired,
    }
    state = {
        searchTerm: '',
    }
    debouncedSearchDeals = debounce(this.props.searchDeals, 300)
    handleChange = (searchTerm) => {
        this.setState({ searchTerm }, () => {
            this.debouncedSearchDeals(this.state.searchTerm)
        })
    }
    render() {
        return (
            <TextInput placeholder='Search all deals' style={style.search} onChangeText={this.handleChange} />
        )
    }
}

const style = StyleSheet.create({
    search: {
        height: 40,
        marginHorizontal: 12
    }
})
