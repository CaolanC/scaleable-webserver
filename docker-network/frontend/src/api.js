const apiUrl = process.env.REACT_APP_API_URL;

export const getData = async (endpoint) => {
  try {
    const response = await fetch('${apiUrl}${endpoint}');
    if (!response.ok) {
      throw new Error('Network response was not ok');
    }
    return await response.json();
  } catch (error) {
    console.error('Error fetching data:', error);
    throw error;
  }
};
