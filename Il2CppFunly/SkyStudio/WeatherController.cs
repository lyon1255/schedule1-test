using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x0200012F RID: 303
	public class WeatherController : MonoBehaviour
	{
		// Token: 0x060019CF RID: 6607 RVA: 0x000C12E4 File Offset: 0x000BF4E4
		// Note: this type is marked as 'beforefieldinit'.
		static WeatherController()
		{
			Il2CppClassPointerStore<WeatherController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "WeatherController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeatherController>.NativeClassPtr);
			WeatherController.NativeFieldInfoPtr__rainDownfallController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, "<rainDownfallController>k__BackingField");
			WeatherController.NativeFieldInfoPtr__rainSplashController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, "<rainSplashController>k__BackingField");
			WeatherController.NativeFieldInfoPtr__lightningController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, "<lightningController>k__BackingField");
			WeatherController.NativeFieldInfoPtr__weatherDepthCamera_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, "<weatherDepthCamera>k__BackingField");
			WeatherController.NativeFieldInfoPtr_m_Enclosure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, "m_Enclosure");
			WeatherController.NativeFieldInfoPtr_m_EnclosureMeshRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, "m_EnclosureMeshRenderer");
			WeatherController.NativeFieldInfoPtr_detector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, "detector");
			WeatherController.NativeFieldInfoPtr_m_Profile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, "m_Profile");
			WeatherController.NativeFieldInfoPtr_m_TimeOfDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, "m_TimeOfDay");
			WeatherController.NativeMethodInfoPtr_get_rainDownfallController_Public_get_RainDownfallController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, 100666037);
			WeatherController.NativeMethodInfoPtr_set_rainDownfallController_Protected_set_Void_RainDownfallController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, 100666038);
			WeatherController.NativeMethodInfoPtr_get_rainSplashController_Public_get_RainSplashController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, 100666039);
			WeatherController.NativeMethodInfoPtr_set_rainSplashController_Protected_set_Void_RainSplashController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, 100666040);
			WeatherController.NativeMethodInfoPtr_get_lightningController_Public_get_LightningController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, 100666041);
			WeatherController.NativeMethodInfoPtr_set_lightningController_Protected_set_Void_LightningController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, 100666042);
			WeatherController.NativeMethodInfoPtr_get_weatherDepthCamera_Public_get_WeatherDepthCamera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, 100666043);
			WeatherController.NativeMethodInfoPtr_set_weatherDepthCamera_Protected_set_Void_WeatherDepthCamera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, 100666044);
			WeatherController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, 100666045);
			WeatherController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, 100666046);
			WeatherController.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, 100666047);
			WeatherController.NativeMethodInfoPtr_DiscoverWeatherControllers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, 100666048);
			WeatherController.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, 100666049);
			WeatherController.NativeMethodInfoPtr_UpdateForTimeOfDay_Public_Void_SkyProfile_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, 100666050);
			WeatherController.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, 100666051);
			WeatherController.NativeMethodInfoPtr_OnEnclosureDidChange_Private_Void_WeatherEnclosure_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, 100666052);
			WeatherController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, 100666053);
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x060019D0 RID: 6608 RVA: 0x000C151C File Offset: 0x000BF71C
		// (set) Token: 0x060019D1 RID: 6609 RVA: 0x000C155C File Offset: 0x000BF75C
		public unsafe RainDownfallController rainDownfallController
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17402, RefRangeEnd = 17403, XrefRangeStart = 17402, XrefRangeEnd = 17403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherController.NativeMethodInfoPtr_get_rainDownfallController_Public_get_RainDownfallController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RainDownfallController>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherController.NativeMethodInfoPtr_set_rainDownfallController_Protected_set_Void_RainDownfallController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x060019D2 RID: 6610 RVA: 0x000C15A0 File Offset: 0x000BF7A0
		// (set) Token: 0x060019D3 RID: 6611 RVA: 0x000C15E0 File Offset: 0x000BF7E0
		public unsafe RainSplashController rainSplashController
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19639, RefRangeEnd = 19642, XrefRangeStart = 19639, XrefRangeEnd = 19642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherController.NativeMethodInfoPtr_get_rainSplashController_Public_get_RainSplashController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RainSplashController>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19643, RefRangeEnd = 19646, XrefRangeStart = 19643, XrefRangeEnd = 19646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherController.NativeMethodInfoPtr_set_rainSplashController_Protected_set_Void_RainSplashController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x060019D4 RID: 6612 RVA: 0x000C1624 File Offset: 0x000BF824
		// (set) Token: 0x060019D5 RID: 6613 RVA: 0x000C1664 File Offset: 0x000BF864
		public unsafe LightningController lightningController
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19646, RefRangeEnd = 19660, XrefRangeStart = 19646, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherController.NativeMethodInfoPtr_get_lightningController_Public_get_LightningController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LightningController>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 19661, RefRangeEnd = 19662, XrefRangeStart = 19661, XrefRangeEnd = 19662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherController.NativeMethodInfoPtr_set_lightningController_Protected_set_Void_LightningController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x060019D6 RID: 6614 RVA: 0x000C16A8 File Offset: 0x000BF8A8
		// (set) Token: 0x060019D7 RID: 6615 RVA: 0x000C16E8 File Offset: 0x000BF8E8
		public unsafe WeatherDepthCamera weatherDepthCamera
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 19662, RefRangeEnd = 19669, XrefRangeStart = 19662, XrefRangeEnd = 19669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherController.NativeMethodInfoPtr_get_weatherDepthCamera_Public_get_WeatherDepthCamera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WeatherDepthCamera>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherController.NativeMethodInfoPtr_set_weatherDepthCamera_Protected_set_Void_WeatherDepthCamera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019D8 RID: 6616 RVA: 0x000C172C File Offset: 0x000BF92C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96715, XrefRangeEnd = 96716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019D9 RID: 6617 RVA: 0x000C1760 File Offset: 0x000BF960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019DA RID: 6618 RVA: 0x000C1794 File Offset: 0x000BF994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96716, XrefRangeEnd = 96743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherController.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019DB RID: 6619 RVA: 0x000C17C8 File Offset: 0x000BF9C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 96763, RefRangeEnd = 96766, XrefRangeStart = 96743, XrefRangeEnd = 96763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DiscoverWeatherControllers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherController.NativeMethodInfoPtr_DiscoverWeatherControllers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019DC RID: 6620 RVA: 0x000C17FC File Offset: 0x000BF9FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96766, XrefRangeEnd = 96783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherController.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019DD RID: 6621 RVA: 0x000C1830 File Offset: 0x000BFA30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 96807, RefRangeEnd = 96809, XrefRangeStart = 96783, XrefRangeEnd = 96807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(skyProfile);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeOfDay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherController.NativeMethodInfoPtr_UpdateForTimeOfDay_Public_Void_SkyProfile_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019DE RID: 6622 RVA: 0x000C1880 File Offset: 0x000BFA80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96809, XrefRangeEnd = 96823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherController.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x000C18B4 File Offset: 0x000BFAB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96823, XrefRangeEnd = 96835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnclosureDidChange(WeatherEnclosure enclosure)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(enclosure);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherController.NativeMethodInfoPtr_OnEnclosureDidChange_Private_Void_WeatherEnclosure_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019E0 RID: 6624 RVA: 0x000C18F8 File Offset: 0x000BFAF8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeatherController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeatherController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019E1 RID: 6625 RVA: 0x0000EB20 File Offset: 0x0000CD20
		public WeatherController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x060019E2 RID: 6626 RVA: 0x000C1934 File Offset: 0x000BFB34
		// (set) Token: 0x060019E3 RID: 6627 RVA: 0x0000EB29 File Offset: 0x0000CD29
		public unsafe RainDownfallController _rainDownfallController_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherController.NativeFieldInfoPtr__rainDownfallController_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RainDownfallController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherController.NativeFieldInfoPtr__rainDownfallController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x060019E4 RID: 6628 RVA: 0x000C1964 File Offset: 0x000BFB64
		// (set) Token: 0x060019E5 RID: 6629 RVA: 0x0000EB48 File Offset: 0x0000CD48
		public unsafe RainSplashController _rainSplashController_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherController.NativeFieldInfoPtr__rainSplashController_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RainSplashController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherController.NativeFieldInfoPtr__rainSplashController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x060019E6 RID: 6630 RVA: 0x000C1994 File Offset: 0x000BFB94
		// (set) Token: 0x060019E7 RID: 6631 RVA: 0x0000EB67 File Offset: 0x0000CD67
		public unsafe LightningController _lightningController_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherController.NativeFieldInfoPtr__lightningController_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LightningController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherController.NativeFieldInfoPtr__lightningController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x060019E8 RID: 6632 RVA: 0x000C19C4 File Offset: 0x000BFBC4
		// (set) Token: 0x060019E9 RID: 6633 RVA: 0x0000EB86 File Offset: 0x0000CD86
		public unsafe WeatherDepthCamera _weatherDepthCamera_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherController.NativeFieldInfoPtr__weatherDepthCamera_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeatherDepthCamera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherController.NativeFieldInfoPtr__weatherDepthCamera_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x060019EA RID: 6634 RVA: 0x000C19F4 File Offset: 0x000BFBF4
		// (set) Token: 0x060019EB RID: 6635 RVA: 0x0000EBA5 File Offset: 0x0000CDA5
		public unsafe WeatherEnclosure m_Enclosure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherController.NativeFieldInfoPtr_m_Enclosure);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeatherEnclosure>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherController.NativeFieldInfoPtr_m_Enclosure), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x060019EC RID: 6636 RVA: 0x000C1A24 File Offset: 0x000BFC24
		// (set) Token: 0x060019ED RID: 6637 RVA: 0x0000EBC4 File Offset: 0x0000CDC4
		public unsafe MeshRenderer m_EnclosureMeshRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherController.NativeFieldInfoPtr_m_EnclosureMeshRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherController.NativeFieldInfoPtr_m_EnclosureMeshRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x060019EE RID: 6638 RVA: 0x000C1A54 File Offset: 0x000BFC54
		// (set) Token: 0x060019EF RID: 6639 RVA: 0x0000EBE3 File Offset: 0x0000CDE3
		public unsafe WeatherEnclosureDetector detector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherController.NativeFieldInfoPtr_detector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeatherEnclosureDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherController.NativeFieldInfoPtr_detector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x060019F0 RID: 6640 RVA: 0x000C1A84 File Offset: 0x000BFC84
		// (set) Token: 0x060019F1 RID: 6641 RVA: 0x0000EC02 File Offset: 0x0000CE02
		public unsafe SkyProfile m_Profile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherController.NativeFieldInfoPtr_m_Profile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkyProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherController.NativeFieldInfoPtr_m_Profile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x060019F2 RID: 6642 RVA: 0x000C1AB4 File Offset: 0x000BFCB4
		// (set) Token: 0x060019F3 RID: 6643 RVA: 0x0000EC21 File Offset: 0x0000CE21
		public unsafe float m_TimeOfDay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherController.NativeFieldInfoPtr_m_TimeOfDay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherController.NativeFieldInfoPtr_m_TimeOfDay)) = value;
			}
		}

		// Token: 0x040010F1 RID: 4337
		private static readonly IntPtr NativeFieldInfoPtr__rainDownfallController_k__BackingField;

		// Token: 0x040010F2 RID: 4338
		private static readonly IntPtr NativeFieldInfoPtr__rainSplashController_k__BackingField;

		// Token: 0x040010F3 RID: 4339
		private static readonly IntPtr NativeFieldInfoPtr__lightningController_k__BackingField;

		// Token: 0x040010F4 RID: 4340
		private static readonly IntPtr NativeFieldInfoPtr__weatherDepthCamera_k__BackingField;

		// Token: 0x040010F5 RID: 4341
		private static readonly IntPtr NativeFieldInfoPtr_m_Enclosure;

		// Token: 0x040010F6 RID: 4342
		private static readonly IntPtr NativeFieldInfoPtr_m_EnclosureMeshRenderer;

		// Token: 0x040010F7 RID: 4343
		private static readonly IntPtr NativeFieldInfoPtr_detector;

		// Token: 0x040010F8 RID: 4344
		private static readonly IntPtr NativeFieldInfoPtr_m_Profile;

		// Token: 0x040010F9 RID: 4345
		private static readonly IntPtr NativeFieldInfoPtr_m_TimeOfDay;

		// Token: 0x040010FA RID: 4346
		private static readonly IntPtr NativeMethodInfoPtr_get_rainDownfallController_Public_get_RainDownfallController_0;

		// Token: 0x040010FB RID: 4347
		private static readonly IntPtr NativeMethodInfoPtr_set_rainDownfallController_Protected_set_Void_RainDownfallController_0;

		// Token: 0x040010FC RID: 4348
		private static readonly IntPtr NativeMethodInfoPtr_get_rainSplashController_Public_get_RainSplashController_0;

		// Token: 0x040010FD RID: 4349
		private static readonly IntPtr NativeMethodInfoPtr_set_rainSplashController_Protected_set_Void_RainSplashController_0;

		// Token: 0x040010FE RID: 4350
		private static readonly IntPtr NativeMethodInfoPtr_get_lightningController_Public_get_LightningController_0;

		// Token: 0x040010FF RID: 4351
		private static readonly IntPtr NativeMethodInfoPtr_set_lightningController_Protected_set_Void_LightningController_0;

		// Token: 0x04001100 RID: 4352
		private static readonly IntPtr NativeMethodInfoPtr_get_weatherDepthCamera_Public_get_WeatherDepthCamera_0;

		// Token: 0x04001101 RID: 4353
		private static readonly IntPtr NativeMethodInfoPtr_set_weatherDepthCamera_Protected_set_Void_WeatherDepthCamera_0;

		// Token: 0x04001102 RID: 4354
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001103 RID: 4355
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001104 RID: 4356
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04001105 RID: 4357
		private static readonly IntPtr NativeMethodInfoPtr_DiscoverWeatherControllers_Private_Void_0;

		// Token: 0x04001106 RID: 4358
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04001107 RID: 4359
		private static readonly IntPtr NativeMethodInfoPtr_UpdateForTimeOfDay_Public_Void_SkyProfile_Single_0;

		// Token: 0x04001108 RID: 4360
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04001109 RID: 4361
		private static readonly IntPtr NativeMethodInfoPtr_OnEnclosureDidChange_Private_Void_WeatherEnclosure_0;

		// Token: 0x0400110A RID: 4362
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
