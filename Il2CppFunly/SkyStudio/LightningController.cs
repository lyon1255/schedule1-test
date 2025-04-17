using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000127 RID: 295
	public class LightningController : MonoBehaviour
	{
		// Token: 0x0600192E RID: 6446 RVA: 0x000BF300 File Offset: 0x000BD500
		// Note: this type is marked as 'beforefieldinit'.
		static LightningController()
		{
			Il2CppClassPointerStore<LightningController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "LightningController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningController>.NativeClassPtr);
			LightningController.NativeFieldInfoPtr_m_SkyProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningController>.NativeClassPtr, "m_SkyProfile");
			LightningController.NativeFieldInfoPtr_m_TimeOfDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningController>.NativeClassPtr, "m_TimeOfDay");
			LightningController.NativeFieldInfoPtr_m_LightningRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningController>.NativeClassPtr, "m_LightningRenderers");
			LightningController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningController>.NativeClassPtr, 100665979);
			LightningController.NativeMethodInfoPtr_UpdateForTimeOfDay_Public_Virtual_Final_New_Void_SkyProfile_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningController>.NativeClassPtr, 100665980);
			LightningController.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningController>.NativeClassPtr, 100665981);
			LightningController.NativeMethodInfoPtr_ClearLightningRenderers_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningController>.NativeClassPtr, 100665982);
			LightningController.NativeMethodInfoPtr_CreateLightningRenderers_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningController>.NativeClassPtr, 100665983);
			LightningController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningController>.NativeClassPtr, 100665984);
		}

		// Token: 0x0600192F RID: 6447 RVA: 0x000BF3E4 File Offset: 0x000BD5E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95952, XrefRangeEnd = 95961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001930 RID: 6448 RVA: 0x000BF418 File Offset: 0x000BD618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95961, XrefRangeEnd = 95962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(skyProfile);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeOfDay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningController.NativeMethodInfoPtr_UpdateForTimeOfDay_Public_Virtual_Final_New_Void_SkyProfile_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001931 RID: 6449 RVA: 0x000BF468 File Offset: 0x000BD668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95962, XrefRangeEnd = 96006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningController.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001932 RID: 6450 RVA: 0x000BF49C File Offset: 0x000BD69C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 96019, RefRangeEnd = 96022, XrefRangeStart = 96006, XrefRangeEnd = 96019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearLightningRenderers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningController.NativeMethodInfoPtr_ClearLightningRenderers_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001933 RID: 6451 RVA: 0x000BF4D0 File Offset: 0x000BD6D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 96041, RefRangeEnd = 96042, XrefRangeStart = 96022, XrefRangeEnd = 96041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateLightningRenderers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningController.NativeMethodInfoPtr_CreateLightningRenderers_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001934 RID: 6452 RVA: 0x000BF504 File Offset: 0x000BD704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96042, XrefRangeEnd = 96050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightningController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightningController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001935 RID: 6453 RVA: 0x0000E5F6 File Offset: 0x0000C7F6
		public LightningController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x06001936 RID: 6454 RVA: 0x000BF540 File Offset: 0x000BD740
		// (set) Token: 0x06001937 RID: 6455 RVA: 0x0000E5FF File Offset: 0x0000C7FF
		public unsafe SkyProfile m_SkyProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningController.NativeFieldInfoPtr_m_SkyProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkyProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningController.NativeFieldInfoPtr_m_SkyProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x06001938 RID: 6456 RVA: 0x000BF570 File Offset: 0x000BD770
		// (set) Token: 0x06001939 RID: 6457 RVA: 0x0000E61E File Offset: 0x0000C81E
		public unsafe float m_TimeOfDay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningController.NativeFieldInfoPtr_m_TimeOfDay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningController.NativeFieldInfoPtr_m_TimeOfDay)) = value;
			}
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x0600193A RID: 6458 RVA: 0x000BF598 File Offset: 0x000BD798
		// (set) Token: 0x0600193B RID: 6459 RVA: 0x0000E639 File Offset: 0x0000C839
		public unsafe List<LightningRenderer> m_LightningRenderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningController.NativeFieldInfoPtr_m_LightningRenderers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LightningRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningController.NativeFieldInfoPtr_m_LightningRenderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400108C RID: 4236
		private static readonly IntPtr NativeFieldInfoPtr_m_SkyProfile;

		// Token: 0x0400108D RID: 4237
		private static readonly IntPtr NativeFieldInfoPtr_m_TimeOfDay;

		// Token: 0x0400108E RID: 4238
		private static readonly IntPtr NativeFieldInfoPtr_m_LightningRenderers;

		// Token: 0x0400108F RID: 4239
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001090 RID: 4240
		private static readonly IntPtr NativeMethodInfoPtr_UpdateForTimeOfDay_Public_Virtual_Final_New_Void_SkyProfile_Single_0;

		// Token: 0x04001091 RID: 4241
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04001092 RID: 4242
		private static readonly IntPtr NativeMethodInfoPtr_ClearLightningRenderers_Public_Void_0;

		// Token: 0x04001093 RID: 4243
		private static readonly IntPtr NativeMethodInfoPtr_CreateLightningRenderers_Public_Void_0;

		// Token: 0x04001094 RID: 4244
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
