import axios from "axios";

const api = createInstance("https://localhost:3000");
export { api };

function createInstance(baseURL: string) {
	var instance = axios.create({
		baseURL,
		withCredentials: true,
		headers: {
			Accept: "application/json",
			"Content-Type": "application/json",
		},
	});
	return instance;
}