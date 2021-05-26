

#include <iostream>
#include <shellscalingapi.h>

int main()
{
    std::cout << "Hello World!\n";
    HRESULT GetDpiForMonitor(
        HMONITOR         hmonitor,
        MONITOR_DPI_TYPE dpiType,
        UINT * dpiX,
        UINT * dpiY
    );


    HRESULT t = GetDpiForMonitor();

}

