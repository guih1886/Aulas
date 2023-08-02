import { CurrentUserLoader } from "./CurrentUserLoader";
import { ResourceLoader } from "./ResourceLoader";
import { UserInfo } from './UserInfo'
import { ProductInfo } from './ProductInfo'
import { UserLoader } from "./UserLoader";
import { DataSource } from "./DataSource";
import axios from "axios";

const getServerData = (url) => async () => {
	const response = await axios.get(url)
	return response.data
}

function App() {
	return (
		<>
			<CurrentUserLoader>
				<UserInfo />
			</CurrentUserLoader>
			<UserLoader userId='3'>
				<UserInfo />
			</UserLoader>
			<UserLoader userId={'4'}>
				<UserInfo />
			</UserLoader>
			<ResourceLoader resourceUrl={'/users/2'} resourceName={'user'}>
				<UserInfo />
			</ResourceLoader>
			<ResourceLoader resourceUrl={'/products/p1'} resourceName={'product'}>
				<ProductInfo />
			</ResourceLoader>
			<DataSource getData={getServerData('/users/3')} resourceName={'user'}>
				<UserInfo />
			</DataSource>
		</>
	);
}

export default App;
