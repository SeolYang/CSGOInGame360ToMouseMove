#include <iostream>

int main()
{
	double Yaw = double();
	double Pitch = double();
	double InGameSensitivity = double();
	double DPI = double();
	double WinSensitivity = double();
	double EffectiveDPI = double();
	double CMPer360DegPitch = double();
	double CMPer360DegYaw = double();
	int RawInput = int();

	std::cout << "DPI: ";
	std::cin >> DPI;

	std::cout << "Windows Sensitivity: ";
	std::cin >> WinSensitivity;
	WinSensitivity /= 10.0;

	std::cout << "In-Game Sensitivity: ";
	std::cin >> InGameSensitivity;

	std::cout << "m_yaw: ";
	std::cin >> Yaw;
	
	std::cout << "m_pitch: ";
	std::cin >> Pitch;

	std::cout << "m_rawinput: ";
	std::cin >> RawInput;

	if (RawInput)
	{
		EffectiveDPI = DPI * InGameSensitivity;
	}
	else
	{
		EffectiveDPI = DPI * InGameSensitivity * WinSensitivity;
	}

	CMPer360DegPitch = (360.0 / (EffectiveDPI * Pitch)) * 2.54;
	CMPer360DegYaw = (360.0 / (EffectiveDPI * Yaw)) * 2.54;

	std::cout << "Effective DPI: " << EffectiveDPI << std::endl;

	std::cout << "Pitch(x): " << CMPer360DegPitch << " cm/360¡Æ" << std::endl;
	std::cout << "Yaw(y): " << CMPer360DegYaw << " cm/360¡Æ" << std::endl;

	return 0;
}