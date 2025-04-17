using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x02000778 RID: 1912
	public class FoliageRustleSound : MonoBehaviour
	{
		// Token: 0x0600B52E RID: 46382 RVA: 0x002D10B4 File Offset: 0x002CF2B4
		// Note: this type is marked as 'beforefieldinit'.
		static FoliageRustleSound()
		{
			Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "FoliageRustleSound");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr);
			FoliageRustleSound.NativeFieldInfoPtr_ACTIVATION_RANGE_SQUARED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr, "ACTIVATION_RANGE_SQUARED");
			FoliageRustleSound.NativeFieldInfoPtr_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr, "COOLDOWN");
			FoliageRustleSound.NativeFieldInfoPtr_Sound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr, "Sound");
			FoliageRustleSound.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr, "Container");
			FoliageRustleSound.NativeFieldInfoPtr_timeOnLastHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr, "timeOnLastHit");
			FoliageRustleSound.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr, 100685582);
			FoliageRustleSound.NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr, 100685583);
			FoliageRustleSound.NativeMethodInfoPtr_UpdateActive_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr, 100685584);
			FoliageRustleSound.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr, 100685585);
		}

		// Token: 0x0600B52F RID: 46383 RVA: 0x002D1198 File Offset: 0x002CF398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309856, XrefRangeEnd = 309862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FoliageRustleSound.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B530 RID: 46384 RVA: 0x002D11CC File Offset: 0x002CF3CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309862, XrefRangeEnd = 309887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FoliageRustleSound.NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B531 RID: 46385 RVA: 0x002D1210 File Offset: 0x002CF410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309887, XrefRangeEnd = 309902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FoliageRustleSound.NativeMethodInfoPtr_UpdateActive_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B532 RID: 46386 RVA: 0x002D1244 File Offset: 0x002CF444
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FoliageRustleSound() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FoliageRustleSound.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B533 RID: 46387 RVA: 0x00058E4D File Offset: 0x0005704D
		public FoliageRustleSound(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003829 RID: 14377
		// (get) Token: 0x0600B534 RID: 46388 RVA: 0x002D1280 File Offset: 0x002CF480
		// (set) Token: 0x0600B535 RID: 46389 RVA: 0x00058E56 File Offset: 0x00057056
		public unsafe static float ACTIVATION_RANGE_SQUARED
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(FoliageRustleSound.NativeFieldInfoPtr_ACTIVATION_RANGE_SQUARED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FoliageRustleSound.NativeFieldInfoPtr_ACTIVATION_RANGE_SQUARED, (void*)(&value));
			}
		}

		// Token: 0x1700382A RID: 14378
		// (get) Token: 0x0600B536 RID: 46390 RVA: 0x002D129C File Offset: 0x002CF49C
		// (set) Token: 0x0600B537 RID: 46391 RVA: 0x00058E64 File Offset: 0x00057064
		public unsafe static float COOLDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(FoliageRustleSound.NativeFieldInfoPtr_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FoliageRustleSound.NativeFieldInfoPtr_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x1700382B RID: 14379
		// (get) Token: 0x0600B538 RID: 46392 RVA: 0x002D12B8 File Offset: 0x002CF4B8
		// (set) Token: 0x0600B539 RID: 46393 RVA: 0x00058E72 File Offset: 0x00057072
		public unsafe AudioSourceController Sound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FoliageRustleSound.NativeFieldInfoPtr_Sound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FoliageRustleSound.NativeFieldInfoPtr_Sound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700382C RID: 14380
		// (get) Token: 0x0600B53A RID: 46394 RVA: 0x002D12E8 File Offset: 0x002CF4E8
		// (set) Token: 0x0600B53B RID: 46395 RVA: 0x00058E91 File Offset: 0x00057091
		public unsafe GameObject Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FoliageRustleSound.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FoliageRustleSound.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700382D RID: 14381
		// (get) Token: 0x0600B53C RID: 46396 RVA: 0x002D1318 File Offset: 0x002CF518
		// (set) Token: 0x0600B53D RID: 46397 RVA: 0x00058EB0 File Offset: 0x000570B0
		public unsafe float timeOnLastHit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FoliageRustleSound.NativeFieldInfoPtr_timeOnLastHit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FoliageRustleSound.NativeFieldInfoPtr_timeOnLastHit)) = value;
			}
		}

		// Token: 0x04007A1F RID: 31263
		private static readonly IntPtr NativeFieldInfoPtr_ACTIVATION_RANGE_SQUARED;

		// Token: 0x04007A20 RID: 31264
		private static readonly IntPtr NativeFieldInfoPtr_COOLDOWN;

		// Token: 0x04007A21 RID: 31265
		private static readonly IntPtr NativeFieldInfoPtr_Sound;

		// Token: 0x04007A22 RID: 31266
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04007A23 RID: 31267
		private static readonly IntPtr NativeFieldInfoPtr_timeOnLastHit;

		// Token: 0x04007A24 RID: 31268
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04007A25 RID: 31269
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0;

		// Token: 0x04007A26 RID: 31270
		private static readonly IntPtr NativeMethodInfoPtr_UpdateActive_Private_Void_0;

		// Token: 0x04007A27 RID: 31271
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
