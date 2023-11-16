# NetCore-Spa-Extension

A simple project to configure a .NET Core 7+ Web API project to target an SPA server in HTTPS during development.

## Setup Steps

1. **Open Solution:**
   - Open the solution in your preferred IDE.

2. **Configure VueApp:**
   - Navigate to the `vueapp` directory using CMD.
   - Run `npm run dev` to start the Vite server.
   - Ensure that Vite is running the SPA on `https://localhost:6500` (verify in `vite.config.ts`).

3. **Configure WebAPI:**
   - Navigate to the `webapi` directory.
   - Run the application in https debug mode.
   - The Kestrel server should be running on `https://localhost:3000` (verify in `Properties/launchSettings.json`).

4. **Verify SPA Page:**
   - You can close the page that Vite opened at `https://localhost:6500`.
   - Access `https://localhost:3000` to view the same SPA page with Hot Module Replacement (HRM) enabled.

That's it! Your setup is now ready, and you can start developing with your .NET Core Web API and SPA. If you encounter any issues, double-check the configuration steps and make sure all the URLs match. Happy coding!

## Contribution Guidelines

Feel free to contribute to this project by opening issues or submitting pull requests. Your feedback and collaboration are highly appreciated!

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.
