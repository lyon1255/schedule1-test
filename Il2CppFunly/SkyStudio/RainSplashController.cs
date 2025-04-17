using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x0200012B RID: 299
	public class RainSplashController : MonoBehaviour
	{
		// Token: 0x06001980 RID: 6528 RVA: 0x000C03E0 File Offset: 0x000BE5E0
		// Note: this type is marked as 'beforefieldinit'.
		static RainSplashController()
		{
			Il2CppClassPointerStore<RainSplashController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "RainSplashController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RainSplashController>.NativeClassPtr);
			RainSplashController.NativeFieldInfoPtr_m_SkyProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainSplashController>.NativeClassPtr, "m_SkyProfile");
			RainSplashController.NativeFieldInfoPtr_m_TimeOfDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainSplashController>.NativeClassPtr, "m_TimeOfDay");
			RainSplashController.NativeFieldInfoPtr_m_SplashRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainSplashController>.NativeClassPtr, "m_SplashRenderers");
			RainSplashController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashController>.NativeClassPtr, 100666012);
			RainSplashController.NativeMethodInfoPtr_UpdateForTimeOfDay_Public_Virtual_Final_New_Void_SkyProfile_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashController>.NativeClassPtr, 100666013);
			RainSplashController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashController>.NativeClassPtr, 100666014);
			RainSplashController.NativeMethodInfoPtr_ClearSplashRenderers_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashController>.NativeClassPtr, 100666015);
			RainSplashController.NativeMethodInfoPtr_CreateSplashRenderers_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashController>.NativeClassPtr, 100666016);
			RainSplashController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashController>.NativeClassPtr, 100666017);
		}

		// Token: 0x06001981 RID: 6529 RVA: 0x000C04C4 File Offset: 0x000BE6C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96424, XrefRangeEnd = 96433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RainSplashController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001982 RID: 6530 RVA: 0x000C04F8 File Offset: 0x000BE6F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(skyProfile);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeOfDay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RainSplashController.NativeMethodInfoPtr_UpdateForTimeOfDay_Public_Virtual_Final_New_Void_SkyProfile_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001983 RID: 6531 RVA: 0x000C0548 File Offset: 0x000BE748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96433, XrefRangeEnd = 96462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RainSplashController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001984 RID: 6532 RVA: 0x000C057C File Offset: 0x000BE77C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 96475, RefRangeEnd = 96478, XrefRangeStart = 96462, XrefRangeEnd = 96475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearSplashRenderers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RainSplashController.NativeMethodInfoPtr_ClearSplashRenderers_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001985 RID: 6533 RVA: 0x000C05B0 File Offset: 0x000BE7B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 96497, RefRangeEnd = 96498, XrefRangeStart = 96478, XrefRangeEnd = 96497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateSplashRenderers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RainSplashController.NativeMethodInfoPtr_CreateSplashRenderers_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001986 RID: 6534 RVA: 0x000C05E4 File Offset: 0x000BE7E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96498, XrefRangeEnd = 96506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RainSplashController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RainSplashController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RainSplashController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001987 RID: 6535 RVA: 0x0000E863 File Offset: 0x0000CA63
		public RainSplashController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x06001988 RID: 6536 RVA: 0x000C0620 File Offset: 0x000BE820
		// (set) Token: 0x06001989 RID: 6537 RVA: 0x0000E86C File Offset: 0x0000CA6C
		public unsafe SkyProfile m_SkyProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashController.NativeFieldInfoPtr_m_SkyProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkyProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashController.NativeFieldInfoPtr_m_SkyProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x0600198A RID: 6538 RVA: 0x000C0650 File Offset: 0x000BE850
		// (set) Token: 0x0600198B RID: 6539 RVA: 0x0000E88B File Offset: 0x0000CA8B
		public unsafe float m_TimeOfDay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashController.NativeFieldInfoPtr_m_TimeOfDay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashController.NativeFieldInfoPtr_m_TimeOfDay)) = value;
			}
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x0600198C RID: 6540 RVA: 0x000C0678 File Offset: 0x000BE878
		// (set) Token: 0x0600198D RID: 6541 RVA: 0x0000E8A6 File Offset: 0x0000CAA6
		public unsafe List<RainSplashRenderer> m_SplashRenderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashController.NativeFieldInfoPtr_m_SplashRenderers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RainSplashRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashController.NativeFieldInfoPtr_m_SplashRenderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010C1 RID: 4289
		private static readonly IntPtr NativeFieldInfoPtr_m_SkyProfile;

		// Token: 0x040010C2 RID: 4290
		private static readonly IntPtr NativeFieldInfoPtr_m_TimeOfDay;

		// Token: 0x040010C3 RID: 4291
		private static readonly IntPtr NativeFieldInfoPtr_m_SplashRenderers;

		// Token: 0x040010C4 RID: 4292
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040010C5 RID: 4293
		private static readonly IntPtr NativeMethodInfoPtr_UpdateForTimeOfDay_Public_Virtual_Final_New_Void_SkyProfile_Single_0;

		// Token: 0x040010C6 RID: 4294
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040010C7 RID: 4295
		private static readonly IntPtr NativeMethodInfoPtr_ClearSplashRenderers_Public_Void_0;

		// Token: 0x040010C8 RID: 4296
		private static readonly IntPtr NativeMethodInfoPtr_CreateSplashRenderers_Public_Void_0;

		// Token: 0x040010C9 RID: 4297
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
