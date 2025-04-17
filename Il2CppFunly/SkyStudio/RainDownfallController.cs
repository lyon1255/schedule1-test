using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x0200012A RID: 298
	public class RainDownfallController : MonoBehaviour
	{
		// Token: 0x0600196E RID: 6510 RVA: 0x000C00CC File Offset: 0x000BE2CC
		// Note: this type is marked as 'beforefieldinit'.
		static RainDownfallController()
		{
			Il2CppClassPointerStore<RainDownfallController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "RainDownfallController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RainDownfallController>.NativeClassPtr);
			RainDownfallController.NativeFieldInfoPtr_rainMeshRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainDownfallController>.NativeClassPtr, "rainMeshRenderer");
			RainDownfallController.NativeFieldInfoPtr_rainMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainDownfallController>.NativeClassPtr, "rainMaterial");
			RainDownfallController.NativeFieldInfoPtr_m_PropertyBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainDownfallController>.NativeClassPtr, "m_PropertyBlock");
			RainDownfallController.NativeFieldInfoPtr_m_RainAudioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainDownfallController>.NativeClassPtr, "m_RainAudioSource");
			RainDownfallController.NativeFieldInfoPtr_m_TimeOfDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainDownfallController>.NativeClassPtr, "m_TimeOfDay");
			RainDownfallController.NativeFieldInfoPtr_m_SkyProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainDownfallController>.NativeClassPtr, "m_SkyProfile");
			RainDownfallController.NativeMethodInfoPtr_SetWeatherEnclosure_Public_Void_WeatherEnclosure_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainDownfallController>.NativeClassPtr, 100666008);
			RainDownfallController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainDownfallController>.NativeClassPtr, 100666009);
			RainDownfallController.NativeMethodInfoPtr_UpdateForTimeOfDay_Public_Virtual_Final_New_Void_SkyProfile_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainDownfallController>.NativeClassPtr, 100666010);
			RainDownfallController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainDownfallController>.NativeClassPtr, 100666011);
		}

		// Token: 0x0600196F RID: 6511 RVA: 0x000C01C4 File Offset: 0x000BE3C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 96294, RefRangeEnd = 96295, XrefRangeStart = 96265, XrefRangeEnd = 96294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWeatherEnclosure(WeatherEnclosure enclosure)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(enclosure);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RainDownfallController.NativeMethodInfoPtr_SetWeatherEnclosure_Public_Void_WeatherEnclosure_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001970 RID: 6512 RVA: 0x000C0208 File Offset: 0x000BE408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96295, XrefRangeEnd = 96300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RainDownfallController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001971 RID: 6513 RVA: 0x000C023C File Offset: 0x000BE43C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 96421, RefRangeEnd = 96424, XrefRangeStart = 96300, XrefRangeEnd = 96421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(skyProfile);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeOfDay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RainDownfallController.NativeMethodInfoPtr_UpdateForTimeOfDay_Public_Virtual_Final_New_Void_SkyProfile_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001972 RID: 6514 RVA: 0x000C028C File Offset: 0x000BE48C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RainDownfallController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RainDownfallController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RainDownfallController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001973 RID: 6515 RVA: 0x0000E7A4 File Offset: 0x0000C9A4
		public RainDownfallController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x06001974 RID: 6516 RVA: 0x000C02C8 File Offset: 0x000BE4C8
		// (set) Token: 0x06001975 RID: 6517 RVA: 0x0000E7AD File Offset: 0x0000C9AD
		public unsafe MeshRenderer rainMeshRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainDownfallController.NativeFieldInfoPtr_rainMeshRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainDownfallController.NativeFieldInfoPtr_rainMeshRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06001976 RID: 6518 RVA: 0x000C02F8 File Offset: 0x000BE4F8
		// (set) Token: 0x06001977 RID: 6519 RVA: 0x0000E7CC File Offset: 0x0000C9CC
		public unsafe Material rainMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainDownfallController.NativeFieldInfoPtr_rainMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainDownfallController.NativeFieldInfoPtr_rainMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x06001978 RID: 6520 RVA: 0x000C0328 File Offset: 0x000BE528
		// (set) Token: 0x06001979 RID: 6521 RVA: 0x0000E7EB File Offset: 0x0000C9EB
		public unsafe MaterialPropertyBlock m_PropertyBlock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainDownfallController.NativeFieldInfoPtr_m_PropertyBlock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaterialPropertyBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainDownfallController.NativeFieldInfoPtr_m_PropertyBlock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x0600197A RID: 6522 RVA: 0x000C0358 File Offset: 0x000BE558
		// (set) Token: 0x0600197B RID: 6523 RVA: 0x0000E80A File Offset: 0x0000CA0A
		public unsafe AudioSource m_RainAudioSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainDownfallController.NativeFieldInfoPtr_m_RainAudioSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainDownfallController.NativeFieldInfoPtr_m_RainAudioSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x0600197C RID: 6524 RVA: 0x000C0388 File Offset: 0x000BE588
		// (set) Token: 0x0600197D RID: 6525 RVA: 0x0000E829 File Offset: 0x0000CA29
		public unsafe float m_TimeOfDay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainDownfallController.NativeFieldInfoPtr_m_TimeOfDay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainDownfallController.NativeFieldInfoPtr_m_TimeOfDay)) = value;
			}
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x0600197E RID: 6526 RVA: 0x000C03B0 File Offset: 0x000BE5B0
		// (set) Token: 0x0600197F RID: 6527 RVA: 0x0000E844 File Offset: 0x0000CA44
		public unsafe SkyProfile m_SkyProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainDownfallController.NativeFieldInfoPtr_m_SkyProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkyProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainDownfallController.NativeFieldInfoPtr_m_SkyProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010B7 RID: 4279
		private static readonly IntPtr NativeFieldInfoPtr_rainMeshRenderer;

		// Token: 0x040010B8 RID: 4280
		private static readonly IntPtr NativeFieldInfoPtr_rainMaterial;

		// Token: 0x040010B9 RID: 4281
		private static readonly IntPtr NativeFieldInfoPtr_m_PropertyBlock;

		// Token: 0x040010BA RID: 4282
		private static readonly IntPtr NativeFieldInfoPtr_m_RainAudioSource;

		// Token: 0x040010BB RID: 4283
		private static readonly IntPtr NativeFieldInfoPtr_m_TimeOfDay;

		// Token: 0x040010BC RID: 4284
		private static readonly IntPtr NativeFieldInfoPtr_m_SkyProfile;

		// Token: 0x040010BD RID: 4285
		private static readonly IntPtr NativeMethodInfoPtr_SetWeatherEnclosure_Public_Void_WeatherEnclosure_0;

		// Token: 0x040010BE RID: 4286
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040010BF RID: 4287
		private static readonly IntPtr NativeMethodInfoPtr_UpdateForTimeOfDay_Public_Virtual_Final_New_Void_SkyProfile_Single_0;

		// Token: 0x040010C0 RID: 4288
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
