# IntricateEngine.ImGui.NET

> Originally forked from [ImGui.NET](https://github.com/ImGuiNET/ImGui.NET) by mellinoe.

This is a .NET wrapper for the immediate mode GUI library, [Dear ImGui](https://github.com/ocornut/imgui) built for the Intricate Engine. This wrapper is built on top of [cimgui](https://github.com/cimgui/cimgui), which exposes a plain C API for Dear ImGui.

This wrapper also includes support for popular ImGui extensions such as:
- [ImGuizmo](https://github.com/CedricGuillemet/ImGuizmo)
- ImNodes *(Pending implementation)*
- ImPlot *(Pending implementation)*

# Usage

ImGui.NET currently provides a raw wrapper around the ImGui native API, and also provides a very thin safe, managed API for convenience. It is currently very much like using the native library, which is very simple, flexible, and robust. The easiest way to figure out how to use the library is to read the documentation of imgui itself, mostly in the `imgui.cpp`, and `imgui.h` files, as well as the exported functions in `cimgui.h`. Looking at the [sample program code](https://github.com/DnA-IntRicate/IntricateEngine.ImGui.NET/tree/master/src/SampleProgram) will also give some indication about basic usage.

# See Also

https://github.com/ocornut/imgui
> Dear ImGui is a bloat-free graphical user interface library for C++. It outputs optimized vertex buffers that you can render anytime in your 3D-pipeline enabled application. It is fast, portable, renderer agnostic and self-contained (no external dependencies).

> Dear ImGui is designed to enable fast iterations and to empower programmers to create content creation tools and visualization / debug tools (as opposed to UI for the average end-user). It favors simplicity and productivity toward this goal, and lacks certain features normally found in more high-level libraries.

> Dear ImGui is particularly suited to integration in games engine (for tooling), real-time 3D applications, fullscreen applications, embedded applications, or any applications on consoles platforms where operating system features are non-standard.

See the [official screenshot thread](https://github.com/ocornut/imgui/issues/123) for examples of many different kinds of interfaces created with Dear ImGui.

https://github.com/cimgui/cimgui
> This is a thin c-api wrapper for the excellent C++ intermediate gui imgui. This library is intended as a intermediate layer to be able to use imgui from other languages that can interface with C .
