using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000F1 RID: 241
	public class BlendSkyProfiles : MonoBehaviour
	{
		// Token: 0x0600128A RID: 4746 RVA: 0x000AB300 File Offset: 0x000A9500
		// Note: this type is marked as 'beforefieldinit'.
		static BlendSkyProfiles()
		{
			Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "BlendSkyProfiles");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr);
			BlendSkyProfiles.NativeFieldInfoPtr__fromProfile_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, "<fromProfile>k__BackingField");
			BlendSkyProfiles.NativeFieldInfoPtr__toProfile_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, "<toProfile>k__BackingField");
			BlendSkyProfiles.NativeFieldInfoPtr__blendedProfile_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, "<blendedProfile>k__BackingField");
			BlendSkyProfiles.NativeFieldInfoPtr_onBlendComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, "onBlendComplete");
			BlendSkyProfiles.NativeFieldInfoPtr_m_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, "m_StartTime");
			BlendSkyProfiles.NativeFieldInfoPtr_m_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, "m_EndTime");
			BlendSkyProfiles.NativeFieldInfoPtr_skyBlender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, "skyBlender");
			BlendSkyProfiles.NativeFieldInfoPtr_sunBlender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, "sunBlender");
			BlendSkyProfiles.NativeFieldInfoPtr_moonBlender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, "moonBlender");
			BlendSkyProfiles.NativeFieldInfoPtr_cloudBlender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, "cloudBlender");
			BlendSkyProfiles.NativeFieldInfoPtr_starLayer1Blender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, "starLayer1Blender");
			BlendSkyProfiles.NativeFieldInfoPtr_starLayer2Blender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, "starLayer2Blender");
			BlendSkyProfiles.NativeFieldInfoPtr_starLayer3Blender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, "starLayer3Blender");
			BlendSkyProfiles.NativeFieldInfoPtr_rainBlender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, "rainBlender");
			BlendSkyProfiles.NativeFieldInfoPtr_rainSplashBlender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, "rainSplashBlender");
			BlendSkyProfiles.NativeFieldInfoPtr_lightningBlender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, "lightningBlender");
			BlendSkyProfiles.NativeFieldInfoPtr_fogBlender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, "fogBlender");
			BlendSkyProfiles.NativeFieldInfoPtr_m_IsBlendingFirstHalf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, "m_IsBlendingFirstHalf");
			BlendSkyProfiles.NativeFieldInfoPtr_m_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, "m_State");
			BlendSkyProfiles.NativeFieldInfoPtr_m_TimeOfDayController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, "m_TimeOfDayController");
			BlendSkyProfiles.NativeFieldInfoPtr_blendingHelper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, "blendingHelper");
			BlendSkyProfiles.NativeMethodInfoPtr_get_fromProfile_Public_get_SkyProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, 100665436);
			BlendSkyProfiles.NativeMethodInfoPtr_set_fromProfile_Private_set_Void_SkyProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, 100665437);
			BlendSkyProfiles.NativeMethodInfoPtr_get_toProfile_Public_get_SkyProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, 100665438);
			BlendSkyProfiles.NativeMethodInfoPtr_set_toProfile_Private_set_Void_SkyProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, 100665439);
			BlendSkyProfiles.NativeMethodInfoPtr_get_blendedProfile_Public_get_SkyProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, 100665440);
			BlendSkyProfiles.NativeMethodInfoPtr_set_blendedProfile_Private_set_Void_SkyProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, 100665441);
			BlendSkyProfiles.NativeMethodInfoPtr_StartBlending_Public_SkyProfile_TimeOfDayController_SkyProfile_SkyProfile_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, 100665442);
			BlendSkyProfiles.NativeMethodInfoPtr_CancelBlending_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, 100665443);
			BlendSkyProfiles.NativeMethodInfoPtr_TearDownBlending_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, 100665444);
			BlendSkyProfiles.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, 100665445);
			BlendSkyProfiles.NativeMethodInfoPtr_UpdateBlendedProfile_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, 100665446);
			BlendSkyProfiles.NativeMethodInfoPtr_PercentForMode_Private_Single_ProfileFeatureBlendingMode_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, 100665447);
			BlendSkyProfiles.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, 100665448);
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x0600128B RID: 4747 RVA: 0x000AB5D8 File Offset: 0x000A97D8
		// (set) Token: 0x0600128C RID: 4748 RVA: 0x000AB618 File Offset: 0x000A9818
		public unsafe SkyProfile fromProfile
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17402, RefRangeEnd = 17403, XrefRangeStart = 17402, XrefRangeEnd = 17403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendSkyProfiles.NativeMethodInfoPtr_get_fromProfile_Public_get_SkyProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SkyProfile>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendSkyProfiles.NativeMethodInfoPtr_set_fromProfile_Private_set_Void_SkyProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x0600128D RID: 4749 RVA: 0x000AB65C File Offset: 0x000A985C
		// (set) Token: 0x0600128E RID: 4750 RVA: 0x000AB69C File Offset: 0x000A989C
		public unsafe SkyProfile toProfile
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19639, RefRangeEnd = 19642, XrefRangeStart = 19639, XrefRangeEnd = 19642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendSkyProfiles.NativeMethodInfoPtr_get_toProfile_Public_get_SkyProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SkyProfile>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19643, RefRangeEnd = 19646, XrefRangeStart = 19643, XrefRangeEnd = 19646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendSkyProfiles.NativeMethodInfoPtr_set_toProfile_Private_set_Void_SkyProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x0600128F RID: 4751 RVA: 0x000AB6E0 File Offset: 0x000A98E0
		// (set) Token: 0x06001290 RID: 4752 RVA: 0x000AB720 File Offset: 0x000A9920
		public unsafe SkyProfile blendedProfile
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19646, RefRangeEnd = 19660, XrefRangeStart = 19646, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendSkyProfiles.NativeMethodInfoPtr_get_blendedProfile_Public_get_SkyProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SkyProfile>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 19661, RefRangeEnd = 19662, XrefRangeStart = 19661, XrefRangeEnd = 19662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendSkyProfiles.NativeMethodInfoPtr_set_blendedProfile_Private_set_Void_SkyProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x000AB764 File Offset: 0x000A9964
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 89912, RefRangeEnd = 89913, XrefRangeStart = 89846, XrefRangeEnd = 89912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkyProfile StartBlending(TimeOfDayController controller, SkyProfile fromProfile, SkyProfile toProfile, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fromProfile);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toProfile);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendSkyProfiles.NativeMethodInfoPtr_StartBlending_Public_SkyProfile_TimeOfDayController_SkyProfile_SkyProfile_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SkyProfile>(intPtr3) : null;
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x000AB7E8 File Offset: 0x000A99E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89913, XrefRangeEnd = 89914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelBlending()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendSkyProfiles.NativeMethodInfoPtr_CancelBlending_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x000AB81C File Offset: 0x000A9A1C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 89925, RefRangeEnd = 89929, XrefRangeStart = 89914, XrefRangeEnd = 89925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TearDownBlending()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendSkyProfiles.NativeMethodInfoPtr_TearDownBlending_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x000AB850 File Offset: 0x000A9A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89929, XrefRangeEnd = 89934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendSkyProfiles.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001295 RID: 4757 RVA: 0x000AB884 File Offset: 0x000A9A84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 89982, RefRangeEnd = 89984, XrefRangeStart = 89934, XrefRangeEnd = 89982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBlendedProfile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendSkyProfiles.NativeMethodInfoPtr_UpdateBlendedProfile_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001296 RID: 4758 RVA: 0x000AB8B8 File Offset: 0x000A9AB8
		[CallerCount(0)]
		public unsafe float PercentForMode(ProfileFeatureBlendingMode mode, float percent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref percent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendSkyProfiles.NativeMethodInfoPtr_PercentForMode_Private_Single_ProfileFeatureBlendingMode_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x000AB910 File Offset: 0x000A9B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89984, XrefRangeEnd = 89985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlendSkyProfiles() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendSkyProfiles.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x0000B1FF File Offset: 0x000093FF
		public BlendSkyProfiles(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06001299 RID: 4761 RVA: 0x000AB94C File Offset: 0x000A9B4C
		// (set) Token: 0x0600129A RID: 4762 RVA: 0x0000B208 File Offset: 0x00009408
		public unsafe SkyProfile _fromProfile_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr__fromProfile_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkyProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr__fromProfile_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x0600129B RID: 4763 RVA: 0x000AB97C File Offset: 0x000A9B7C
		// (set) Token: 0x0600129C RID: 4764 RVA: 0x0000B227 File Offset: 0x00009427
		public unsafe SkyProfile _toProfile_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr__toProfile_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkyProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr__toProfile_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x0600129D RID: 4765 RVA: 0x000AB9AC File Offset: 0x000A9BAC
		// (set) Token: 0x0600129E RID: 4766 RVA: 0x0000B246 File Offset: 0x00009446
		public unsafe SkyProfile _blendedProfile_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr__blendedProfile_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkyProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr__blendedProfile_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x0600129F RID: 4767 RVA: 0x000AB9DC File Offset: 0x000A9BDC
		// (set) Token: 0x060012A0 RID: 4768 RVA: 0x0000B265 File Offset: 0x00009465
		public unsafe Action<BlendSkyProfiles> onBlendComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_onBlendComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<BlendSkyProfiles>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_onBlendComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x060012A1 RID: 4769 RVA: 0x000ABA0C File Offset: 0x000A9C0C
		// (set) Token: 0x060012A2 RID: 4770 RVA: 0x0000B284 File Offset: 0x00009484
		public unsafe float m_StartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_m_StartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_m_StartTime)) = value;
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x060012A3 RID: 4771 RVA: 0x000ABA34 File Offset: 0x000A9C34
		// (set) Token: 0x060012A4 RID: 4772 RVA: 0x0000B29F File Offset: 0x0000949F
		public unsafe float m_EndTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_m_EndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_m_EndTime)) = value;
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x060012A5 RID: 4773 RVA: 0x000ABA5C File Offset: 0x000A9C5C
		// (set) Token: 0x060012A6 RID: 4774 RVA: 0x0000B2BA File Offset: 0x000094BA
		public unsafe FeatureBlender skyBlender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_skyBlender);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FeatureBlender>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_skyBlender), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x060012A7 RID: 4775 RVA: 0x000ABA8C File Offset: 0x000A9C8C
		// (set) Token: 0x060012A8 RID: 4776 RVA: 0x0000B2D9 File Offset: 0x000094D9
		public unsafe FeatureBlender sunBlender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_sunBlender);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FeatureBlender>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_sunBlender), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x060012A9 RID: 4777 RVA: 0x000ABABC File Offset: 0x000A9CBC
		// (set) Token: 0x060012AA RID: 4778 RVA: 0x0000B2F8 File Offset: 0x000094F8
		public unsafe FeatureBlender moonBlender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_moonBlender);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FeatureBlender>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_moonBlender), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x060012AB RID: 4779 RVA: 0x000ABAEC File Offset: 0x000A9CEC
		// (set) Token: 0x060012AC RID: 4780 RVA: 0x0000B317 File Offset: 0x00009517
		public unsafe FeatureBlender cloudBlender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_cloudBlender);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FeatureBlender>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_cloudBlender), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x060012AD RID: 4781 RVA: 0x000ABB1C File Offset: 0x000A9D1C
		// (set) Token: 0x060012AE RID: 4782 RVA: 0x0000B336 File Offset: 0x00009536
		public unsafe FeatureBlender starLayer1Blender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_starLayer1Blender);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FeatureBlender>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_starLayer1Blender), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x060012AF RID: 4783 RVA: 0x000ABB4C File Offset: 0x000A9D4C
		// (set) Token: 0x060012B0 RID: 4784 RVA: 0x0000B355 File Offset: 0x00009555
		public unsafe FeatureBlender starLayer2Blender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_starLayer2Blender);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FeatureBlender>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_starLayer2Blender), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x060012B1 RID: 4785 RVA: 0x000ABB7C File Offset: 0x000A9D7C
		// (set) Token: 0x060012B2 RID: 4786 RVA: 0x0000B374 File Offset: 0x00009574
		public unsafe FeatureBlender starLayer3Blender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_starLayer3Blender);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FeatureBlender>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_starLayer3Blender), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x060012B3 RID: 4787 RVA: 0x000ABBAC File Offset: 0x000A9DAC
		// (set) Token: 0x060012B4 RID: 4788 RVA: 0x0000B393 File Offset: 0x00009593
		public unsafe FeatureBlender rainBlender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_rainBlender);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FeatureBlender>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_rainBlender), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x060012B5 RID: 4789 RVA: 0x000ABBDC File Offset: 0x000A9DDC
		// (set) Token: 0x060012B6 RID: 4790 RVA: 0x0000B3B2 File Offset: 0x000095B2
		public unsafe FeatureBlender rainSplashBlender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_rainSplashBlender);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FeatureBlender>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_rainSplashBlender), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x060012B7 RID: 4791 RVA: 0x000ABC0C File Offset: 0x000A9E0C
		// (set) Token: 0x060012B8 RID: 4792 RVA: 0x0000B3D1 File Offset: 0x000095D1
		public unsafe FeatureBlender lightningBlender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_lightningBlender);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FeatureBlender>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_lightningBlender), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x060012B9 RID: 4793 RVA: 0x000ABC3C File Offset: 0x000A9E3C
		// (set) Token: 0x060012BA RID: 4794 RVA: 0x0000B3F0 File Offset: 0x000095F0
		public unsafe FeatureBlender fogBlender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_fogBlender);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FeatureBlender>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_fogBlender), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x060012BB RID: 4795 RVA: 0x000ABC6C File Offset: 0x000A9E6C
		// (set) Token: 0x060012BC RID: 4796 RVA: 0x0000B40F File Offset: 0x0000960F
		public unsafe bool m_IsBlendingFirstHalf
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_m_IsBlendingFirstHalf);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_m_IsBlendingFirstHalf)) = value;
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x060012BD RID: 4797 RVA: 0x000ABC94 File Offset: 0x000A9E94
		// (set) Token: 0x060012BE RID: 4798 RVA: 0x0000B42A File Offset: 0x0000962A
		public ProfileBlendingState m_State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_m_State);
				return new ProfileBlendingState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfileBlendingState>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_m_State), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ProfileBlendingState>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x060012BF RID: 4799 RVA: 0x000ABCC4 File Offset: 0x000A9EC4
		// (set) Token: 0x060012C0 RID: 4800 RVA: 0x0000B458 File Offset: 0x00009658
		public unsafe TimeOfDayController m_TimeOfDayController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_m_TimeOfDayController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeOfDayController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_m_TimeOfDayController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x060012C1 RID: 4801 RVA: 0x000ABCF4 File Offset: 0x000A9EF4
		// (set) Token: 0x060012C2 RID: 4802 RVA: 0x0000B477 File Offset: 0x00009677
		public unsafe BlendingHelper blendingHelper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_blendingHelper);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlendingHelper>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_blendingHelper), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C53 RID: 3155
		private static readonly IntPtr NativeFieldInfoPtr__fromProfile_k__BackingField;

		// Token: 0x04000C54 RID: 3156
		private static readonly IntPtr NativeFieldInfoPtr__toProfile_k__BackingField;

		// Token: 0x04000C55 RID: 3157
		private static readonly IntPtr NativeFieldInfoPtr__blendedProfile_k__BackingField;

		// Token: 0x04000C56 RID: 3158
		private static readonly IntPtr NativeFieldInfoPtr_onBlendComplete;

		// Token: 0x04000C57 RID: 3159
		private static readonly IntPtr NativeFieldInfoPtr_m_StartTime;

		// Token: 0x04000C58 RID: 3160
		private static readonly IntPtr NativeFieldInfoPtr_m_EndTime;

		// Token: 0x04000C59 RID: 3161
		private static readonly IntPtr NativeFieldInfoPtr_skyBlender;

		// Token: 0x04000C5A RID: 3162
		private static readonly IntPtr NativeFieldInfoPtr_sunBlender;

		// Token: 0x04000C5B RID: 3163
		private static readonly IntPtr NativeFieldInfoPtr_moonBlender;

		// Token: 0x04000C5C RID: 3164
		private static readonly IntPtr NativeFieldInfoPtr_cloudBlender;

		// Token: 0x04000C5D RID: 3165
		private static readonly IntPtr NativeFieldInfoPtr_starLayer1Blender;

		// Token: 0x04000C5E RID: 3166
		private static readonly IntPtr NativeFieldInfoPtr_starLayer2Blender;

		// Token: 0x04000C5F RID: 3167
		private static readonly IntPtr NativeFieldInfoPtr_starLayer3Blender;

		// Token: 0x04000C60 RID: 3168
		private static readonly IntPtr NativeFieldInfoPtr_rainBlender;

		// Token: 0x04000C61 RID: 3169
		private static readonly IntPtr NativeFieldInfoPtr_rainSplashBlender;

		// Token: 0x04000C62 RID: 3170
		private static readonly IntPtr NativeFieldInfoPtr_lightningBlender;

		// Token: 0x04000C63 RID: 3171
		private static readonly IntPtr NativeFieldInfoPtr_fogBlender;

		// Token: 0x04000C64 RID: 3172
		private static readonly IntPtr NativeFieldInfoPtr_m_IsBlendingFirstHalf;

		// Token: 0x04000C65 RID: 3173
		private static readonly IntPtr NativeFieldInfoPtr_m_State;

		// Token: 0x04000C66 RID: 3174
		private static readonly IntPtr NativeFieldInfoPtr_m_TimeOfDayController;

		// Token: 0x04000C67 RID: 3175
		private static readonly IntPtr NativeFieldInfoPtr_blendingHelper;

		// Token: 0x04000C68 RID: 3176
		private static readonly IntPtr NativeMethodInfoPtr_get_fromProfile_Public_get_SkyProfile_0;

		// Token: 0x04000C69 RID: 3177
		private static readonly IntPtr NativeMethodInfoPtr_set_fromProfile_Private_set_Void_SkyProfile_0;

		// Token: 0x04000C6A RID: 3178
		private static readonly IntPtr NativeMethodInfoPtr_get_toProfile_Public_get_SkyProfile_0;

		// Token: 0x04000C6B RID: 3179
		private static readonly IntPtr NativeMethodInfoPtr_set_toProfile_Private_set_Void_SkyProfile_0;

		// Token: 0x04000C6C RID: 3180
		private static readonly IntPtr NativeMethodInfoPtr_get_blendedProfile_Public_get_SkyProfile_0;

		// Token: 0x04000C6D RID: 3181
		private static readonly IntPtr NativeMethodInfoPtr_set_blendedProfile_Private_set_Void_SkyProfile_0;

		// Token: 0x04000C6E RID: 3182
		private static readonly IntPtr NativeMethodInfoPtr_StartBlending_Public_SkyProfile_TimeOfDayController_SkyProfile_SkyProfile_Single_0;

		// Token: 0x04000C6F RID: 3183
		private static readonly IntPtr NativeMethodInfoPtr_CancelBlending_Public_Void_0;

		// Token: 0x04000C70 RID: 3184
		private static readonly IntPtr NativeMethodInfoPtr_TearDownBlending_Public_Void_0;

		// Token: 0x04000C71 RID: 3185
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000C72 RID: 3186
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBlendedProfile_Private_Void_0;

		// Token: 0x04000C73 RID: 3187
		private static readonly IntPtr NativeMethodInfoPtr_PercentForMode_Private_Single_ProfileFeatureBlendingMode_Single_0;

		// Token: 0x04000C74 RID: 3188
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
