using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.Universal;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000477 RID: 1143
	public class Settings : PersistentSingleton<Settings>
	{
		// Token: 0x060062AE RID: 25262 RVA: 0x001C0504 File Offset: 0x001BE704
		// Note: this type is marked as 'beforefieldinit'.
		static Settings()
		{
			Il2CppClassPointerStore<Settings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "Settings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Settings>.NativeClassPtr);
			Settings.NativeFieldInfoPtr_MinYPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "MinYPos");
			Settings.NativeFieldInfoPtr__unitType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "<unitType>k__BackingField");
			Settings.NativeFieldInfoPtr_DisplaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "DisplaySettings");
			Settings.NativeFieldInfoPtr_UnappliedDisplaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "UnappliedDisplaySettings");
			Settings.NativeFieldInfoPtr_GraphicsSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "GraphicsSettings");
			Settings.NativeFieldInfoPtr_AudioSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "AudioSettings");
			Settings.NativeFieldInfoPtr_InputSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "InputSettings");
			Settings.NativeFieldInfoPtr_InputActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "InputActions");
			Settings.NativeFieldInfoPtr_GameInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "GameInput");
			Settings.NativeFieldInfoPtr_SSAO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "SSAO");
			Settings.NativeFieldInfoPtr_GodRays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "GodRays");
			Settings.NativeFieldInfoPtr_LookSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "LookSensitivity");
			Settings.NativeFieldInfoPtr_InvertMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "InvertMouse");
			Settings.NativeFieldInfoPtr_CameraFOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "CameraFOV");
			Settings.NativeFieldInfoPtr_SprintMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "SprintMode");
			Settings.NativeFieldInfoPtr_CameraBobIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "CameraBobIntensity");
			Settings.NativeFieldInfoPtr_playerControls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "playerControls");
			Settings.NativeFieldInfoPtr_onDisplayChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "onDisplayChanged");
			Settings.NativeFieldInfoPtr_onInputsApplied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "onInputsApplied");
			Settings.NativeMethodInfoPtr_get_unitType_Public_get_UnitType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675810);
			Settings.NativeMethodInfoPtr_set_unitType_Protected_set_Void_UnitType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675811);
			Settings.NativeMethodInfoPtr_get_PausingFreezesTime_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675812);
			Settings.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675813);
			Settings.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675814);
			Settings.NativeMethodInfoPtr_ApplyDisplaySettings_Public_Void_DisplaySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675815);
			Settings.NativeMethodInfoPtr_MoveMainWindowTo_Private_Void_DisplayInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675816);
			Settings.NativeMethodInfoPtr_ReloadGraphicsSettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675817);
			Settings.NativeMethodInfoPtr_ApplyGraphicsSettings_Public_Void_GraphicsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675818);
			Settings.NativeMethodInfoPtr_ReloadAudioSettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675819);
			Settings.NativeMethodInfoPtr_ApplyAudioSettings_Public_Void_AudioSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675820);
			Settings.NativeMethodInfoPtr_ReloadInputSettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675821);
			Settings.NativeMethodInfoPtr_ApplyInputSettings_Public_Void_InputSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675822);
			Settings.NativeMethodInfoPtr_WriteDisplaySettings_Public_Void_DisplaySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675823);
			Settings.NativeMethodInfoPtr_ReadDisplaySettings_Public_DisplaySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675824);
			Settings.NativeMethodInfoPtr_WriteGraphicsSettings_Public_Void_GraphicsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675825);
			Settings.NativeMethodInfoPtr_ReadGraphicsSettings_Public_GraphicsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675826);
			Settings.NativeMethodInfoPtr_WriteAudioSettings_Public_Void_AudioSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675827);
			Settings.NativeMethodInfoPtr_ReadAudioSettings_Public_AudioSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675828);
			Settings.NativeMethodInfoPtr_WriteInputSettings_Public_Void_InputSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675829);
			Settings.NativeMethodInfoPtr_ReadInputSettings_Public_InputSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675830);
			Settings.NativeMethodInfoPtr_GetActionControlPath_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675831);
			Settings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675832);
		}

		// Token: 0x17001DC8 RID: 7624
		// (get) Token: 0x060062AF RID: 25263 RVA: 0x001C087C File Offset: 0x001BEA7C
		// (set) Token: 0x060062B0 RID: 25264 RVA: 0x001C08B8 File Offset: 0x001BEAB8
		public unsafe Settings.UnitType unitType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29987, RefRangeEnd = 29988, XrefRangeStart = 29987, XrefRangeEnd = 29988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_get_unitType_Public_get_UnitType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29988, RefRangeEnd = 29989, XrefRangeStart = 29988, XrefRangeEnd = 29989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_set_unitType_Protected_set_Void_UnitType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001DC9 RID: 7625
		// (get) Token: 0x060062B1 RID: 25265 RVA: 0x001C08F8 File Offset: 0x001BEAF8
		public unsafe bool PausingFreezesTime
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 202256, RefRangeEnd = 202260, XrefRangeStart = 202250, XrefRangeEnd = 202256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_get_PausingFreezesTime_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060062B2 RID: 25266 RVA: 0x001C0934 File Offset: 0x001BEB34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202260, XrefRangeEnd = 202356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Settings.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062B3 RID: 25267 RVA: 0x001C0970 File Offset: 0x001BEB70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202356, XrefRangeEnd = 202365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Settings.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062B4 RID: 25268 RVA: 0x001C09AC File Offset: 0x001BEBAC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 202408, RefRangeEnd = 202411, XrefRangeStart = 202365, XrefRangeEnd = 202408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyDisplaySettings(DisplaySettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref settings;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ApplyDisplaySettings_Public_Void_DisplaySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062B5 RID: 25269 RVA: 0x001C09EC File Offset: 0x001BEBEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202411, XrefRangeEnd = 202419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveMainWindowTo(DisplayInfo displayInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(displayInfo));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_MoveMainWindowTo_Private_Void_DisplayInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062B6 RID: 25270 RVA: 0x001C0A34 File Offset: 0x001BEC34
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 202421, RefRangeEnd = 202426, XrefRangeStart = 202419, XrefRangeEnd = 202421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReloadGraphicsSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ReloadGraphicsSettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062B7 RID: 25271 RVA: 0x001C0A68 File Offset: 0x001BEC68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202426, XrefRangeEnd = 202428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyGraphicsSettings(GraphicsSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ApplyGraphicsSettings_Public_Void_GraphicsSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062B8 RID: 25272 RVA: 0x001C0AAC File Offset: 0x001BECAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 202429, RefRangeEnd = 202430, XrefRangeStart = 202428, XrefRangeEnd = 202429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReloadAudioSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ReloadAudioSettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062B9 RID: 25273 RVA: 0x001C0AE0 File Offset: 0x001BECE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 202459, RefRangeEnd = 202461, XrefRangeStart = 202430, XrefRangeEnd = 202459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyAudioSettings(AudioSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ApplyAudioSettings_Public_Void_AudioSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062BA RID: 25274 RVA: 0x001C0B24 File Offset: 0x001BED24
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 202462, RefRangeEnd = 202465, XrefRangeStart = 202461, XrefRangeEnd = 202462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReloadInputSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ReloadInputSettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062BB RID: 25275 RVA: 0x001C0B58 File Offset: 0x001BED58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 202470, RefRangeEnd = 202472, XrefRangeStart = 202465, XrefRangeEnd = 202470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyInputSettings(InputSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ApplyInputSettings_Public_Void_InputSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062BC RID: 25276 RVA: 0x001C0B9C File Offset: 0x001BED9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 202494, RefRangeEnd = 202495, XrefRangeStart = 202472, XrefRangeEnd = 202494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteDisplaySettings(DisplaySettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref settings;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_WriteDisplaySettings_Public_Void_DisplaySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062BD RID: 25277 RVA: 0x001C0BDC File Offset: 0x001BEDDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 202517, RefRangeEnd = 202519, XrefRangeStart = 202495, XrefRangeEnd = 202517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DisplaySettings ReadDisplaySettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ReadDisplaySettings_Public_DisplaySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060062BE RID: 25278 RVA: 0x001C0C18 File Offset: 0x001BEE18
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 202536, RefRangeEnd = 202541, XrefRangeStart = 202519, XrefRangeEnd = 202536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteGraphicsSettings(GraphicsSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_WriteGraphicsSettings_Public_Void_GraphicsSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062BF RID: 25279 RVA: 0x001C0C5C File Offset: 0x001BEE5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202541, XrefRangeEnd = 202560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraphicsSettings ReadGraphicsSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ReadGraphicsSettings_Public_GraphicsSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GraphicsSettings>(intPtr3) : null;
		}

		// Token: 0x060062C0 RID: 25280 RVA: 0x001C0C9C File Offset: 0x001BEE9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 202583, RefRangeEnd = 202584, XrefRangeStart = 202560, XrefRangeEnd = 202583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteAudioSettings(AudioSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_WriteAudioSettings_Public_Void_AudioSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062C1 RID: 25281 RVA: 0x001C0CE0 File Offset: 0x001BEEE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202584, XrefRangeEnd = 202609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioSettings ReadAudioSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ReadAudioSettings_Public_AudioSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioSettings>(intPtr3) : null;
		}

		// Token: 0x060062C2 RID: 25282 RVA: 0x001C0D20 File Offset: 0x001BEF20
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 202625, RefRangeEnd = 202628, XrefRangeStart = 202609, XrefRangeEnd = 202625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteInputSettings(InputSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_WriteInputSettings_Public_Void_InputSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062C3 RID: 25283 RVA: 0x001C0D64 File Offset: 0x001BEF64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202628, XrefRangeEnd = 202647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputSettings ReadInputSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ReadInputSettings_Public_InputSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputSettings>(intPtr3) : null;
		}

		// Token: 0x060062C4 RID: 25284 RVA: 0x001C0DA4 File Offset: 0x001BEFA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202647, XrefRangeEnd = 202657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetActionControlPath(string actionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_GetActionControlPath_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060062C5 RID: 25285 RVA: 0x001C0DEC File Offset: 0x001BEFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202657, XrefRangeEnd = 202675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Settings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Settings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062C6 RID: 25286 RVA: 0x0002EA77 File Offset: 0x0002CC77
		public Settings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DB5 RID: 7605
		// (get) Token: 0x060062C7 RID: 25287 RVA: 0x001C0E28 File Offset: 0x001BF028
		// (set) Token: 0x060062C8 RID: 25288 RVA: 0x0002EA80 File Offset: 0x0002CC80
		public unsafe static float MinYPos
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Settings.NativeFieldInfoPtr_MinYPos, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Settings.NativeFieldInfoPtr_MinYPos, (void*)(&value));
			}
		}

		// Token: 0x17001DB6 RID: 7606
		// (get) Token: 0x060062C9 RID: 25289 RVA: 0x001C0E44 File Offset: 0x001BF044
		// (set) Token: 0x060062CA RID: 25290 RVA: 0x0002EA8E File Offset: 0x0002CC8E
		public unsafe Settings.UnitType _unitType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr__unitType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr__unitType_k__BackingField)) = value;
			}
		}

		// Token: 0x17001DB7 RID: 7607
		// (get) Token: 0x060062CB RID: 25291 RVA: 0x001C0E6C File Offset: 0x001BF06C
		// (set) Token: 0x060062CC RID: 25292 RVA: 0x0002EAA9 File Offset: 0x0002CCA9
		public unsafe DisplaySettings DisplaySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_DisplaySettings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_DisplaySettings)) = value;
			}
		}

		// Token: 0x17001DB8 RID: 7608
		// (get) Token: 0x060062CD RID: 25293 RVA: 0x001C0E94 File Offset: 0x001BF094
		// (set) Token: 0x060062CE RID: 25294 RVA: 0x0002EAC4 File Offset: 0x0002CCC4
		public unsafe DisplaySettings UnappliedDisplaySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_UnappliedDisplaySettings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_UnappliedDisplaySettings)) = value;
			}
		}

		// Token: 0x17001DB9 RID: 7609
		// (get) Token: 0x060062CF RID: 25295 RVA: 0x001C0EBC File Offset: 0x001BF0BC
		// (set) Token: 0x060062D0 RID: 25296 RVA: 0x0002EADF File Offset: 0x0002CCDF
		public unsafe GraphicsSettings GraphicsSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_GraphicsSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GraphicsSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_GraphicsSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DBA RID: 7610
		// (get) Token: 0x060062D1 RID: 25297 RVA: 0x001C0EEC File Offset: 0x001BF0EC
		// (set) Token: 0x060062D2 RID: 25298 RVA: 0x0002EAFE File Offset: 0x0002CCFE
		public unsafe AudioSettings AudioSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_AudioSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_AudioSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DBB RID: 7611
		// (get) Token: 0x060062D3 RID: 25299 RVA: 0x001C0F1C File Offset: 0x001BF11C
		// (set) Token: 0x060062D4 RID: 25300 RVA: 0x0002EB1D File Offset: 0x0002CD1D
		public unsafe InputSettings InputSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_InputSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_InputSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DBC RID: 7612
		// (get) Token: 0x060062D5 RID: 25301 RVA: 0x001C0F4C File Offset: 0x001BF14C
		// (set) Token: 0x060062D6 RID: 25302 RVA: 0x0002EB3C File Offset: 0x0002CD3C
		public unsafe InputActionAsset InputActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_InputActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_InputActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DBD RID: 7613
		// (get) Token: 0x060062D7 RID: 25303 RVA: 0x001C0F7C File Offset: 0x001BF17C
		// (set) Token: 0x060062D8 RID: 25304 RVA: 0x0002EB5B File Offset: 0x0002CD5B
		public unsafe GameInput GameInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_GameInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameInput>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_GameInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DBE RID: 7614
		// (get) Token: 0x060062D9 RID: 25305 RVA: 0x001C0FAC File Offset: 0x001BF1AC
		// (set) Token: 0x060062DA RID: 25306 RVA: 0x0002EB7A File Offset: 0x0002CD7A
		public unsafe ScriptableRendererFeature SSAO
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_SSAO);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableRendererFeature>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_SSAO), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DBF RID: 7615
		// (get) Token: 0x060062DB RID: 25307 RVA: 0x001C0FDC File Offset: 0x001BF1DC
		// (set) Token: 0x060062DC RID: 25308 RVA: 0x0002EB99 File Offset: 0x0002CD99
		public unsafe ScriptableRendererFeature GodRays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_GodRays);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableRendererFeature>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_GodRays), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DC0 RID: 7616
		// (get) Token: 0x060062DD RID: 25309 RVA: 0x001C100C File Offset: 0x001BF20C
		// (set) Token: 0x060062DE RID: 25310 RVA: 0x0002EBB8 File Offset: 0x0002CDB8
		public unsafe float LookSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_LookSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_LookSensitivity)) = value;
			}
		}

		// Token: 0x17001DC1 RID: 7617
		// (get) Token: 0x060062DF RID: 25311 RVA: 0x001C1034 File Offset: 0x001BF234
		// (set) Token: 0x060062E0 RID: 25312 RVA: 0x0002EBD3 File Offset: 0x0002CDD3
		public unsafe bool InvertMouse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_InvertMouse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_InvertMouse)) = value;
			}
		}

		// Token: 0x17001DC2 RID: 7618
		// (get) Token: 0x060062E1 RID: 25313 RVA: 0x001C105C File Offset: 0x001BF25C
		// (set) Token: 0x060062E2 RID: 25314 RVA: 0x0002EBEE File Offset: 0x0002CDEE
		public unsafe float CameraFOV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_CameraFOV);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_CameraFOV)) = value;
			}
		}

		// Token: 0x17001DC3 RID: 7619
		// (get) Token: 0x060062E3 RID: 25315 RVA: 0x001C1084 File Offset: 0x001BF284
		// (set) Token: 0x060062E4 RID: 25316 RVA: 0x0002EC09 File Offset: 0x0002CE09
		public unsafe InputSettings.EActionMode SprintMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_SprintMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_SprintMode)) = value;
			}
		}

		// Token: 0x17001DC4 RID: 7620
		// (get) Token: 0x060062E5 RID: 25317 RVA: 0x001C10AC File Offset: 0x001BF2AC
		// (set) Token: 0x060062E6 RID: 25318 RVA: 0x0002EC24 File Offset: 0x0002CE24
		public unsafe float CameraBobIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_CameraBobIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_CameraBobIntensity)) = value;
			}
		}

		// Token: 0x17001DC5 RID: 7621
		// (get) Token: 0x060062E7 RID: 25319 RVA: 0x001C10D4 File Offset: 0x001BF2D4
		// (set) Token: 0x060062E8 RID: 25320 RVA: 0x0002EC3F File Offset: 0x0002CE3F
		public unsafe InputActionMap playerControls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_playerControls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionMap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_playerControls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DC6 RID: 7622
		// (get) Token: 0x060062E9 RID: 25321 RVA: 0x001C1104 File Offset: 0x001BF304
		// (set) Token: 0x060062EA RID: 25322 RVA: 0x0002EC5E File Offset: 0x0002CE5E
		public unsafe Action onDisplayChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_onDisplayChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_onDisplayChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DC7 RID: 7623
		// (get) Token: 0x060062EB RID: 25323 RVA: 0x001C1134 File Offset: 0x001BF334
		// (set) Token: 0x060062EC RID: 25324 RVA: 0x0002EC7D File Offset: 0x0002CE7D
		public unsafe Action onInputsApplied
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_onInputsApplied);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_onInputsApplied), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400434F RID: 17231
		private static readonly IntPtr NativeFieldInfoPtr_MinYPos;

		// Token: 0x04004350 RID: 17232
		private static readonly IntPtr NativeFieldInfoPtr__unitType_k__BackingField;

		// Token: 0x04004351 RID: 17233
		private static readonly IntPtr NativeFieldInfoPtr_DisplaySettings;

		// Token: 0x04004352 RID: 17234
		private static readonly IntPtr NativeFieldInfoPtr_UnappliedDisplaySettings;

		// Token: 0x04004353 RID: 17235
		private static readonly IntPtr NativeFieldInfoPtr_GraphicsSettings;

		// Token: 0x04004354 RID: 17236
		private static readonly IntPtr NativeFieldInfoPtr_AudioSettings;

		// Token: 0x04004355 RID: 17237
		private static readonly IntPtr NativeFieldInfoPtr_InputSettings;

		// Token: 0x04004356 RID: 17238
		private static readonly IntPtr NativeFieldInfoPtr_InputActions;

		// Token: 0x04004357 RID: 17239
		private static readonly IntPtr NativeFieldInfoPtr_GameInput;

		// Token: 0x04004358 RID: 17240
		private static readonly IntPtr NativeFieldInfoPtr_SSAO;

		// Token: 0x04004359 RID: 17241
		private static readonly IntPtr NativeFieldInfoPtr_GodRays;

		// Token: 0x0400435A RID: 17242
		private static readonly IntPtr NativeFieldInfoPtr_LookSensitivity;

		// Token: 0x0400435B RID: 17243
		private static readonly IntPtr NativeFieldInfoPtr_InvertMouse;

		// Token: 0x0400435C RID: 17244
		private static readonly IntPtr NativeFieldInfoPtr_CameraFOV;

		// Token: 0x0400435D RID: 17245
		private static readonly IntPtr NativeFieldInfoPtr_SprintMode;

		// Token: 0x0400435E RID: 17246
		private static readonly IntPtr NativeFieldInfoPtr_CameraBobIntensity;

		// Token: 0x0400435F RID: 17247
		private static readonly IntPtr NativeFieldInfoPtr_playerControls;

		// Token: 0x04004360 RID: 17248
		private static readonly IntPtr NativeFieldInfoPtr_onDisplayChanged;

		// Token: 0x04004361 RID: 17249
		private static readonly IntPtr NativeFieldInfoPtr_onInputsApplied;

		// Token: 0x04004362 RID: 17250
		private static readonly IntPtr NativeMethodInfoPtr_get_unitType_Public_get_UnitType_0;

		// Token: 0x04004363 RID: 17251
		private static readonly IntPtr NativeMethodInfoPtr_set_unitType_Protected_set_Void_UnitType_0;

		// Token: 0x04004364 RID: 17252
		private static readonly IntPtr NativeMethodInfoPtr_get_PausingFreezesTime_Public_get_Boolean_0;

		// Token: 0x04004365 RID: 17253
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04004366 RID: 17254
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04004367 RID: 17255
		private static readonly IntPtr NativeMethodInfoPtr_ApplyDisplaySettings_Public_Void_DisplaySettings_0;

		// Token: 0x04004368 RID: 17256
		private static readonly IntPtr NativeMethodInfoPtr_MoveMainWindowTo_Private_Void_DisplayInfo_0;

		// Token: 0x04004369 RID: 17257
		private static readonly IntPtr NativeMethodInfoPtr_ReloadGraphicsSettings_Public_Void_0;

		// Token: 0x0400436A RID: 17258
		private static readonly IntPtr NativeMethodInfoPtr_ApplyGraphicsSettings_Public_Void_GraphicsSettings_0;

		// Token: 0x0400436B RID: 17259
		private static readonly IntPtr NativeMethodInfoPtr_ReloadAudioSettings_Public_Void_0;

		// Token: 0x0400436C RID: 17260
		private static readonly IntPtr NativeMethodInfoPtr_ApplyAudioSettings_Public_Void_AudioSettings_0;

		// Token: 0x0400436D RID: 17261
		private static readonly IntPtr NativeMethodInfoPtr_ReloadInputSettings_Public_Void_0;

		// Token: 0x0400436E RID: 17262
		private static readonly IntPtr NativeMethodInfoPtr_ApplyInputSettings_Public_Void_InputSettings_0;

		// Token: 0x0400436F RID: 17263
		private static readonly IntPtr NativeMethodInfoPtr_WriteDisplaySettings_Public_Void_DisplaySettings_0;

		// Token: 0x04004370 RID: 17264
		private static readonly IntPtr NativeMethodInfoPtr_ReadDisplaySettings_Public_DisplaySettings_0;

		// Token: 0x04004371 RID: 17265
		private static readonly IntPtr NativeMethodInfoPtr_WriteGraphicsSettings_Public_Void_GraphicsSettings_0;

		// Token: 0x04004372 RID: 17266
		private static readonly IntPtr NativeMethodInfoPtr_ReadGraphicsSettings_Public_GraphicsSettings_0;

		// Token: 0x04004373 RID: 17267
		private static readonly IntPtr NativeMethodInfoPtr_WriteAudioSettings_Public_Void_AudioSettings_0;

		// Token: 0x04004374 RID: 17268
		private static readonly IntPtr NativeMethodInfoPtr_ReadAudioSettings_Public_AudioSettings_0;

		// Token: 0x04004375 RID: 17269
		private static readonly IntPtr NativeMethodInfoPtr_WriteInputSettings_Public_Void_InputSettings_0;

		// Token: 0x04004376 RID: 17270
		private static readonly IntPtr NativeMethodInfoPtr_ReadInputSettings_Public_InputSettings_0;

		// Token: 0x04004377 RID: 17271
		private static readonly IntPtr NativeMethodInfoPtr_GetActionControlPath_Public_String_String_0;

		// Token: 0x04004378 RID: 17272
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A24 RID: 2596
		[OriginalName("Assembly-CSharp.dll", "", "UnitType")]
		public enum UnitType
		{
			// Token: 0x04008BC0 RID: 35776
			Metric,
			// Token: 0x04008BC1 RID: 35777
			Imperial
		}
	}
}
