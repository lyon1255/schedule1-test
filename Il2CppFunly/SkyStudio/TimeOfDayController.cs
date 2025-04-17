using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000119 RID: 281
	public class TimeOfDayController : MonoBehaviour
	{
		// Token: 0x0600181E RID: 6174 RVA: 0x000BB94C File Offset: 0x000B9B4C
		// Note: this type is marked as 'beforefieldinit'.
		static TimeOfDayController()
		{
			Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "TimeOfDayController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr);
			TimeOfDayController.NativeFieldInfoPtr__instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, "<instance>k__BackingField");
			TimeOfDayController.NativeFieldInfoPtr_m_SkyProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, "m_SkyProfile");
			TimeOfDayController.NativeFieldInfoPtr_m_SkyTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, "m_SkyTime");
			TimeOfDayController.NativeFieldInfoPtr_automaticTimeIncrement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, "automaticTimeIncrement");
			TimeOfDayController.NativeFieldInfoPtr_copySkyProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, "copySkyProfile");
			TimeOfDayController.NativeFieldInfoPtr_m_SkyMaterialController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, "m_SkyMaterialController");
			TimeOfDayController.NativeFieldInfoPtr_automaticIncrementSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, "automaticIncrementSpeed");
			TimeOfDayController.NativeFieldInfoPtr_sunOrbit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, "sunOrbit");
			TimeOfDayController.NativeFieldInfoPtr_moonOrbit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, "moonOrbit");
			TimeOfDayController.NativeFieldInfoPtr_weatherController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, "weatherController");
			TimeOfDayController.NativeFieldInfoPtr_updateGlobalIllumination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, "updateGlobalIllumination");
			TimeOfDayController.NativeFieldInfoPtr_skyProfileTransitionPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, "skyProfileTransitionPrefab");
			TimeOfDayController.NativeFieldInfoPtr_timeChangedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, "timeChangedCallback");
			TimeOfDayController.NativeFieldInfoPtr_m_DidInitialUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, "m_DidInitialUpdate");
			TimeOfDayController.NativeMethodInfoPtr_get_instance_Public_Static_get_TimeOfDayController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665859);
			TimeOfDayController.NativeMethodInfoPtr_set_instance_Private_Static_set_Void_TimeOfDayController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665860);
			TimeOfDayController.NativeMethodInfoPtr_get_skyProfile_Public_get_SkyProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665861);
			TimeOfDayController.NativeMethodInfoPtr_set_skyProfile_Public_set_Void_SkyProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665862);
			TimeOfDayController.NativeMethodInfoPtr_get_skyTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665863);
			TimeOfDayController.NativeMethodInfoPtr_set_skyTime_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665864);
			TimeOfDayController.NativeMethodInfoPtr_get_SkyMaterial_Public_get_SkyMaterialController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665865);
			TimeOfDayController.NativeMethodInfoPtr_add_timeChangedCallback_Public_add_Void_TimeOfDayDidChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665866);
			TimeOfDayController.NativeMethodInfoPtr_remove_timeChangedCallback_Public_rem_Void_TimeOfDayDidChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665867);
			TimeOfDayController.NativeMethodInfoPtr_get_timeOfDay_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665868);
			TimeOfDayController.NativeMethodInfoPtr_get_daysElapsed_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665869);
			TimeOfDayController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665870);
			TimeOfDayController.NativeMethodInfoPtr_OnEnabled_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665871);
			TimeOfDayController.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665872);
			TimeOfDayController.NativeMethodInfoPtr_WarnInvalidSkySetup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665873);
			TimeOfDayController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665874);
			TimeOfDayController.NativeMethodInfoPtr_UpdateGlobalIllumination_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665875);
			TimeOfDayController.NativeMethodInfoPtr_SynchronizeAllShaderKeywords_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665876);
			TimeOfDayController.NativeMethodInfoPtr_SynchronizedShaderKeyword_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665877);
			TimeOfDayController.NativeMethodInfoPtr_GetPrimaryLightDirection_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665878);
			TimeOfDayController.NativeMethodInfoPtr_StartSkyProfileTransition_Public_Boolean_SkyProfile_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665879);
			TimeOfDayController.NativeMethodInfoPtr_CancelSkyProfileTransition_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665880);
			TimeOfDayController.NativeMethodInfoPtr_OnBlendComplete_Public_Void_BlendSkyProfiles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665881);
			TimeOfDayController.NativeMethodInfoPtr_IsBlendingInProgress_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665882);
			TimeOfDayController.NativeMethodInfoPtr_UpdateSkyForCurrentTime_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665883);
			TimeOfDayController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665884);
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x0600181F RID: 6175 RVA: 0x000BBC9C File Offset: 0x000B9E9C
		// (set) Token: 0x06001820 RID: 6176 RVA: 0x000BBCD0 File Offset: 0x000B9ED0
		public unsafe static TimeOfDayController instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94126, XrefRangeEnd = 94128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_get_instance_Public_Static_get_TimeOfDayController_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeOfDayController>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94128, XrefRangeEnd = 94132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_set_instance_Private_Static_set_Void_TimeOfDayController_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x06001821 RID: 6177 RVA: 0x000BBD08 File Offset: 0x000B9F08
		// (set) Token: 0x06001822 RID: 6178 RVA: 0x000BBD48 File Offset: 0x000B9F48
		public unsafe SkyProfile skyProfile
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17402, RefRangeEnd = 17403, XrefRangeStart = 17402, XrefRangeEnd = 17403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_get_skyProfile_Public_get_SkyProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SkyProfile>(intPtr3) : null;
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 94146, RefRangeEnd = 94153, XrefRangeStart = 94132, XrefRangeEnd = 94146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_set_skyProfile_Public_set_Void_SkyProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x06001823 RID: 6179 RVA: 0x000BBD8C File Offset: 0x000B9F8C
		// (set) Token: 0x06001824 RID: 6180 RVA: 0x000BBDC8 File Offset: 0x000B9FC8
		public unsafe float skyTime
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 59847, RefRangeEnd = 59848, XrefRangeStart = 59847, XrefRangeEnd = 59848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_get_skyTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 94154, RefRangeEnd = 94155, XrefRangeStart = 94153, XrefRangeEnd = 94154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_set_skyTime_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06001825 RID: 6181 RVA: 0x000BBE08 File Offset: 0x000BA008
		public unsafe SkyMaterialController SkyMaterial
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19646, RefRangeEnd = 19660, XrefRangeStart = 19646, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_get_SkyMaterial_Public_get_SkyMaterialController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SkyMaterialController>(intPtr3) : null;
			}
		}

		// Token: 0x06001826 RID: 6182 RVA: 0x000BBE48 File Offset: 0x000BA048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94155, XrefRangeEnd = 94159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_timeChangedCallback(TimeOfDayController.TimeOfDayDidChange value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_add_timeChangedCallback_Public_add_Void_TimeOfDayDidChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001827 RID: 6183 RVA: 0x000BBE8C File Offset: 0x000BA08C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94159, XrefRangeEnd = 94163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_timeChangedCallback(TimeOfDayController.TimeOfDayDidChange value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_remove_timeChangedCallback_Public_rem_Void_TimeOfDayDidChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x06001828 RID: 6184 RVA: 0x000BBED0 File Offset: 0x000BA0D0
		public unsafe float timeOfDay
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_get_timeOfDay_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x06001829 RID: 6185 RVA: 0x000BBF0C File Offset: 0x000BA10C
		public unsafe int daysElapsed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_get_daysElapsed_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600182A RID: 6186 RVA: 0x000BBF48 File Offset: 0x000BA148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94163, XrefRangeEnd = 94167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600182B RID: 6187 RVA: 0x000BBF7C File Offset: 0x000BA17C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94167, XrefRangeEnd = 94168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_OnEnabled_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600182C RID: 6188 RVA: 0x000BBFB0 File Offset: 0x000BA1B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94168, XrefRangeEnd = 94172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600182D RID: 6189 RVA: 0x000BBFE4 File Offset: 0x000BA1E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94172, XrefRangeEnd = 94178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WarnInvalidSkySetup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_WarnInvalidSkySetup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600182E RID: 6190 RVA: 0x000BC018 File Offset: 0x000BA218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94178, XrefRangeEnd = 94271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600182F RID: 6191 RVA: 0x000BC04C File Offset: 0x000BA24C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94271, XrefRangeEnd = 94272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateGlobalIllumination()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_UpdateGlobalIllumination_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001830 RID: 6192 RVA: 0x000BC080 File Offset: 0x000BA280
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 94284, RefRangeEnd = 94286, XrefRangeStart = 94272, XrefRangeEnd = 94284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SynchronizeAllShaderKeywords()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_SynchronizeAllShaderKeywords_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001831 RID: 6193 RVA: 0x000BC0B4 File Offset: 0x000BA2B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 94296, RefRangeEnd = 94298, XrefRangeStart = 94286, XrefRangeEnd = 94296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SynchronizedShaderKeyword(string featureKey, string shaderKeyword)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(featureKey);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(shaderKeyword);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_SynchronizedShaderKeyword_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001832 RID: 6194 RVA: 0x000BC108 File Offset: 0x000BA308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94298, XrefRangeEnd = 94312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPrimaryLightDirection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_GetPrimaryLightDirection_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001833 RID: 6195 RVA: 0x000BC144 File Offset: 0x000BA344
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 94356, RefRangeEnd = 94357, XrefRangeStart = 94312, XrefRangeEnd = 94356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StartSkyProfileTransition(SkyProfile toProfile, float duration = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(toProfile);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_StartSkyProfileTransition_Public_Boolean_SkyProfile_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001834 RID: 6196 RVA: 0x000BC1A0 File Offset: 0x000BA3A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94357, XrefRangeEnd = 94365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelSkyProfileTransition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_CancelSkyProfileTransition_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001835 RID: 6197 RVA: 0x000BC1D4 File Offset: 0x000BA3D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94365, XrefRangeEnd = 94368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBlendComplete(BlendSkyProfiles blender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(blender);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_OnBlendComplete_Public_Void_BlendSkyProfiles_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001836 RID: 6198 RVA: 0x000BC218 File Offset: 0x000BA418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94368, XrefRangeEnd = 94375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsBlendingInProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_IsBlendingInProgress_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001837 RID: 6199 RVA: 0x000BC254 File Offset: 0x000BA454
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 95255, RefRangeEnd = 95263, XrefRangeStart = 94375, XrefRangeEnd = 95255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSkyForCurrentTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_UpdateSkyForCurrentTime_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001838 RID: 6200 RVA: 0x000BC288 File Offset: 0x000BA488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95263, XrefRangeEnd = 95264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeOfDayController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001839 RID: 6201 RVA: 0x0000DE30 File Offset: 0x0000C030
		public TimeOfDayController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x0600183A RID: 6202 RVA: 0x000BC2C4 File Offset: 0x000BA4C4
		// (set) Token: 0x0600183B RID: 6203 RVA: 0x0000DE39 File Offset: 0x0000C039
		public unsafe static TimeOfDayController _instance_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimeOfDayController.NativeFieldInfoPtr__instance_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeOfDayController>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeOfDayController.NativeFieldInfoPtr__instance_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x0600183C RID: 6204 RVA: 0x000BC2EC File Offset: 0x000BA4EC
		// (set) Token: 0x0600183D RID: 6205 RVA: 0x0000DE4B File Offset: 0x0000C04B
		public unsafe SkyProfile m_SkyProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_m_SkyProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkyProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_m_SkyProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x0600183E RID: 6206 RVA: 0x000BC31C File Offset: 0x000BA51C
		// (set) Token: 0x0600183F RID: 6207 RVA: 0x0000DE6A File Offset: 0x0000C06A
		public unsafe float m_SkyTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_m_SkyTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_m_SkyTime)) = value;
			}
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06001840 RID: 6208 RVA: 0x000BC344 File Offset: 0x000BA544
		// (set) Token: 0x06001841 RID: 6209 RVA: 0x0000DE85 File Offset: 0x0000C085
		public unsafe bool automaticTimeIncrement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_automaticTimeIncrement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_automaticTimeIncrement)) = value;
			}
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06001842 RID: 6210 RVA: 0x000BC36C File Offset: 0x000BA56C
		// (set) Token: 0x06001843 RID: 6211 RVA: 0x0000DEA0 File Offset: 0x0000C0A0
		public unsafe bool copySkyProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_copySkyProfile);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_copySkyProfile)) = value;
			}
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06001844 RID: 6212 RVA: 0x000BC394 File Offset: 0x000BA594
		// (set) Token: 0x06001845 RID: 6213 RVA: 0x0000DEBB File Offset: 0x0000C0BB
		public unsafe SkyMaterialController m_SkyMaterialController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_m_SkyMaterialController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkyMaterialController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_m_SkyMaterialController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06001846 RID: 6214 RVA: 0x000BC3C4 File Offset: 0x000BA5C4
		// (set) Token: 0x06001847 RID: 6215 RVA: 0x0000DEDA File Offset: 0x0000C0DA
		public unsafe float automaticIncrementSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_automaticIncrementSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_automaticIncrementSpeed)) = value;
			}
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06001848 RID: 6216 RVA: 0x000BC3EC File Offset: 0x000BA5EC
		// (set) Token: 0x06001849 RID: 6217 RVA: 0x0000DEF5 File Offset: 0x0000C0F5
		public unsafe OrbitingBody sunOrbit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_sunOrbit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OrbitingBody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_sunOrbit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x0600184A RID: 6218 RVA: 0x000BC41C File Offset: 0x000BA61C
		// (set) Token: 0x0600184B RID: 6219 RVA: 0x0000DF14 File Offset: 0x0000C114
		public unsafe OrbitingBody moonOrbit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_moonOrbit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OrbitingBody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_moonOrbit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x0600184C RID: 6220 RVA: 0x000BC44C File Offset: 0x000BA64C
		// (set) Token: 0x0600184D RID: 6221 RVA: 0x0000DF33 File Offset: 0x0000C133
		public unsafe WeatherController weatherController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_weatherController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeatherController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_weatherController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x0600184E RID: 6222 RVA: 0x000BC47C File Offset: 0x000BA67C
		// (set) Token: 0x0600184F RID: 6223 RVA: 0x0000DF52 File Offset: 0x0000C152
		public unsafe bool updateGlobalIllumination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_updateGlobalIllumination);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_updateGlobalIllumination)) = value;
			}
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x06001850 RID: 6224 RVA: 0x000BC4A4 File Offset: 0x000BA6A4
		// (set) Token: 0x06001851 RID: 6225 RVA: 0x0000DF6D File Offset: 0x0000C16D
		public unsafe BlendSkyProfiles skyProfileTransitionPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_skyProfileTransitionPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlendSkyProfiles>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_skyProfileTransitionPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x06001852 RID: 6226 RVA: 0x000BC4D4 File Offset: 0x000BA6D4
		// (set) Token: 0x06001853 RID: 6227 RVA: 0x0000DF8C File Offset: 0x0000C18C
		public unsafe TimeOfDayController.TimeOfDayDidChange timeChangedCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_timeChangedCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeOfDayController.TimeOfDayDidChange>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_timeChangedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x06001854 RID: 6228 RVA: 0x000BC504 File Offset: 0x000BA704
		// (set) Token: 0x06001855 RID: 6229 RVA: 0x0000DFAB File Offset: 0x0000C1AB
		public unsafe bool m_DidInitialUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_m_DidInitialUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_m_DidInitialUpdate)) = value;
			}
		}

		// Token: 0x04000FD8 RID: 4056
		private static readonly IntPtr NativeFieldInfoPtr__instance_k__BackingField;

		// Token: 0x04000FD9 RID: 4057
		private static readonly IntPtr NativeFieldInfoPtr_m_SkyProfile;

		// Token: 0x04000FDA RID: 4058
		private static readonly IntPtr NativeFieldInfoPtr_m_SkyTime;

		// Token: 0x04000FDB RID: 4059
		private static readonly IntPtr NativeFieldInfoPtr_automaticTimeIncrement;

		// Token: 0x04000FDC RID: 4060
		private static readonly IntPtr NativeFieldInfoPtr_copySkyProfile;

		// Token: 0x04000FDD RID: 4061
		private static readonly IntPtr NativeFieldInfoPtr_m_SkyMaterialController;

		// Token: 0x04000FDE RID: 4062
		private static readonly IntPtr NativeFieldInfoPtr_automaticIncrementSpeed;

		// Token: 0x04000FDF RID: 4063
		private static readonly IntPtr NativeFieldInfoPtr_sunOrbit;

		// Token: 0x04000FE0 RID: 4064
		private static readonly IntPtr NativeFieldInfoPtr_moonOrbit;

		// Token: 0x04000FE1 RID: 4065
		private static readonly IntPtr NativeFieldInfoPtr_weatherController;

		// Token: 0x04000FE2 RID: 4066
		private static readonly IntPtr NativeFieldInfoPtr_updateGlobalIllumination;

		// Token: 0x04000FE3 RID: 4067
		private static readonly IntPtr NativeFieldInfoPtr_skyProfileTransitionPrefab;

		// Token: 0x04000FE4 RID: 4068
		private static readonly IntPtr NativeFieldInfoPtr_timeChangedCallback;

		// Token: 0x04000FE5 RID: 4069
		private static readonly IntPtr NativeFieldInfoPtr_m_DidInitialUpdate;

		// Token: 0x04000FE6 RID: 4070
		private static readonly IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_TimeOfDayController_0;

		// Token: 0x04000FE7 RID: 4071
		private static readonly IntPtr NativeMethodInfoPtr_set_instance_Private_Static_set_Void_TimeOfDayController_0;

		// Token: 0x04000FE8 RID: 4072
		private static readonly IntPtr NativeMethodInfoPtr_get_skyProfile_Public_get_SkyProfile_0;

		// Token: 0x04000FE9 RID: 4073
		private static readonly IntPtr NativeMethodInfoPtr_set_skyProfile_Public_set_Void_SkyProfile_0;

		// Token: 0x04000FEA RID: 4074
		private static readonly IntPtr NativeMethodInfoPtr_get_skyTime_Public_get_Single_0;

		// Token: 0x04000FEB RID: 4075
		private static readonly IntPtr NativeMethodInfoPtr_set_skyTime_Public_set_Void_Single_0;

		// Token: 0x04000FEC RID: 4076
		private static readonly IntPtr NativeMethodInfoPtr_get_SkyMaterial_Public_get_SkyMaterialController_0;

		// Token: 0x04000FED RID: 4077
		private static readonly IntPtr NativeMethodInfoPtr_add_timeChangedCallback_Public_add_Void_TimeOfDayDidChange_0;

		// Token: 0x04000FEE RID: 4078
		private static readonly IntPtr NativeMethodInfoPtr_remove_timeChangedCallback_Public_rem_Void_TimeOfDayDidChange_0;

		// Token: 0x04000FEF RID: 4079
		private static readonly IntPtr NativeMethodInfoPtr_get_timeOfDay_Public_get_Single_0;

		// Token: 0x04000FF0 RID: 4080
		private static readonly IntPtr NativeMethodInfoPtr_get_daysElapsed_Public_get_Int32_0;

		// Token: 0x04000FF1 RID: 4081
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000FF2 RID: 4082
		private static readonly IntPtr NativeMethodInfoPtr_OnEnabled_Private_Void_0;

		// Token: 0x04000FF3 RID: 4083
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04000FF4 RID: 4084
		private static readonly IntPtr NativeMethodInfoPtr_WarnInvalidSkySetup_Private_Void_0;

		// Token: 0x04000FF5 RID: 4085
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000FF6 RID: 4086
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGlobalIllumination_Public_Void_0;

		// Token: 0x04000FF7 RID: 4087
		private static readonly IntPtr NativeMethodInfoPtr_SynchronizeAllShaderKeywords_Private_Void_0;

		// Token: 0x04000FF8 RID: 4088
		private static readonly IntPtr NativeMethodInfoPtr_SynchronizedShaderKeyword_Private_Void_String_String_0;

		// Token: 0x04000FF9 RID: 4089
		private static readonly IntPtr NativeMethodInfoPtr_GetPrimaryLightDirection_Private_Vector3_0;

		// Token: 0x04000FFA RID: 4090
		private static readonly IntPtr NativeMethodInfoPtr_StartSkyProfileTransition_Public_Boolean_SkyProfile_Single_0;

		// Token: 0x04000FFB RID: 4091
		private static readonly IntPtr NativeMethodInfoPtr_CancelSkyProfileTransition_Public_Void_0;

		// Token: 0x04000FFC RID: 4092
		private static readonly IntPtr NativeMethodInfoPtr_OnBlendComplete_Public_Void_BlendSkyProfiles_0;

		// Token: 0x04000FFD RID: 4093
		private static readonly IntPtr NativeMethodInfoPtr_IsBlendingInProgress_Public_Boolean_0;

		// Token: 0x04000FFE RID: 4094
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSkyForCurrentTime_Public_Void_0;

		// Token: 0x04000FFF RID: 4095
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000854 RID: 2132
		public sealed class TimeOfDayDidChange : MulticastDelegate
		{
			// Token: 0x0600C053 RID: 49235 RVA: 0x002F06EC File Offset: 0x002EE8EC
			// Note: this type is marked as 'beforefieldinit'.
			static TimeOfDayDidChange()
			{
				Il2CppClassPointerStore<TimeOfDayController.TimeOfDayDidChange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, "TimeOfDayDidChange");
				TimeOfDayController.TimeOfDayDidChange.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController.TimeOfDayDidChange>.NativeClassPtr, 100665885);
				TimeOfDayController.TimeOfDayDidChange.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_TimeOfDayController_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController.TimeOfDayDidChange>.NativeClassPtr, 100665886);
				TimeOfDayController.TimeOfDayDidChange.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_TimeOfDayController_Single_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController.TimeOfDayDidChange>.NativeClassPtr, 100665887);
				TimeOfDayController.TimeOfDayDidChange.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController.TimeOfDayDidChange>.NativeClassPtr, 100665888);
			}

			// Token: 0x0600C054 RID: 49236 RVA: 0x002F0760 File Offset: 0x002EE960
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 72687, RefRangeEnd = 72689, XrefRangeStart = 72687, XrefRangeEnd = 72689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TimeOfDayDidChange(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeOfDayController.TimeOfDayDidChange>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.TimeOfDayDidChange.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C055 RID: 49237 RVA: 0x002F07BC File Offset: 0x002EE9BC
			[CallerCount(0)]
			public unsafe void Invoke(TimeOfDayController tc, float timeOfDay)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tc);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeOfDay;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.TimeOfDayDidChange.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_TimeOfDayController_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C056 RID: 49238 RVA: 0x002F080C File Offset: 0x002EEA0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94122, XrefRangeEnd = 94126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(TimeOfDayController tc, float timeOfDay, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tc);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeOfDay;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.TimeOfDayDidChange.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_TimeOfDayController_Single_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600C057 RID: 49239 RVA: 0x002F0890 File Offset: 0x002EEA90
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22498, RefRangeEnd = 22499, XrefRangeStart = 22498, XrefRangeEnd = 22499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.TimeOfDayDidChange.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C058 RID: 49240 RVA: 0x0005DF57 File Offset: 0x0005C157
			public TimeOfDayDidChange(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600C059 RID: 49241 RVA: 0x0005DF60 File Offset: 0x0005C160
			public static implicit operator TimeOfDayController.TimeOfDayDidChange(Action<TimeOfDayController, float> A_0)
			{
				return DelegateSupport.ConvertDelegate<TimeOfDayController.TimeOfDayDidChange>(A_0);
			}

			// Token: 0x0600C05A RID: 49242 RVA: 0x0005DF68 File Offset: 0x0005C168
			public static TimeOfDayController.TimeOfDayDidChange operator +(TimeOfDayController.TimeOfDayDidChange A_0, TimeOfDayController.TimeOfDayDidChange A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<TimeOfDayController.TimeOfDayDidChange>();
			}

			// Token: 0x0600C05B RID: 49243 RVA: 0x0005DF76 File Offset: 0x0005C176
			public static TimeOfDayController.TimeOfDayDidChange operator -(TimeOfDayController.TimeOfDayDidChange A_0, TimeOfDayController.TimeOfDayDidChange A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<TimeOfDayController.TimeOfDayDidChange>();
				}
				return result;
			}

			// Token: 0x0400824C RID: 33356
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400824D RID: 33357
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_TimeOfDayController_Single_0;

			// Token: 0x0400824E RID: 33358
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_TimeOfDayController_Single_AsyncCallback_Object_0;

			// Token: 0x0400824F RID: 33359
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
