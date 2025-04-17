﻿using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Skating
{
	// Token: 0x020001A9 RID: 425
	public class SkateboardEffects : MonoBehaviour
	{
		// Token: 0x0600240E RID: 9230 RVA: 0x000E0554 File Offset: 0x000DE754
		// Note: this type is marked as 'beforefieldinit'.
		static SkateboardEffects()
		{
			Il2CppClassPointerStore<SkateboardEffects>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Skating", "SkateboardEffects");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkateboardEffects>.NativeClassPtr);
			SkateboardEffects.NativeFieldInfoPtr_skateboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardEffects>.NativeClassPtr, "skateboard");
			SkateboardEffects.NativeFieldInfoPtr_Trails = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardEffects>.NativeClassPtr, "Trails");
			SkateboardEffects.NativeFieldInfoPtr_trailsOpacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardEffects>.NativeClassPtr, "trailsOpacity");
			SkateboardEffects.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardEffects>.NativeClassPtr, 100667292);
			SkateboardEffects.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardEffects>.NativeClassPtr, 100667293);
			SkateboardEffects.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardEffects>.NativeClassPtr, 100667294);
		}

		// Token: 0x0600240F RID: 9231 RVA: 0x000E05FC File Offset: 0x000DE7FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112860, XrefRangeEnd = 112865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardEffects.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002410 RID: 9232 RVA: 0x000E0630 File Offset: 0x000DE830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112865, XrefRangeEnd = 112869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardEffects.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002411 RID: 9233 RVA: 0x000E0664 File Offset: 0x000DE864
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkateboardEffects() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkateboardEffects>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardEffects.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002412 RID: 9234 RVA: 0x00014462 File Offset: 0x00012662
		public SkateboardEffects(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x06002413 RID: 9235 RVA: 0x000E06A0 File Offset: 0x000DE8A0
		// (set) Token: 0x06002414 RID: 9236 RVA: 0x0001446B File Offset: 0x0001266B
		public unsafe Skateboard skateboard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardEffects.NativeFieldInfoPtr_skateboard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardEffects.NativeFieldInfoPtr_skateboard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C73 RID: 3187
		// (get) Token: 0x06002415 RID: 9237 RVA: 0x000E06D0 File Offset: 0x000DE8D0
		// (set) Token: 0x06002416 RID: 9238 RVA: 0x0001448A File Offset: 0x0001268A
		public unsafe Il2CppReferenceArray<TrailRenderer> Trails
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardEffects.NativeFieldInfoPtr_Trails);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TrailRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardEffects.NativeFieldInfoPtr_Trails), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x06002417 RID: 9239 RVA: 0x000E0700 File Offset: 0x000DE900
		// (set) Token: 0x06002418 RID: 9240 RVA: 0x000144A9 File Offset: 0x000126A9
		public unsafe float trailsOpacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardEffects.NativeFieldInfoPtr_trailsOpacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardEffects.NativeFieldInfoPtr_trailsOpacity)) = value;
			}
		}

		// Token: 0x040017E4 RID: 6116
		private static readonly IntPtr NativeFieldInfoPtr_skateboard;

		// Token: 0x040017E5 RID: 6117
		private static readonly IntPtr NativeFieldInfoPtr_Trails;

		// Token: 0x040017E6 RID: 6118
		private static readonly IntPtr NativeFieldInfoPtr_trailsOpacity;

		// Token: 0x040017E7 RID: 6119
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040017E8 RID: 6120
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040017E9 RID: 6121
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
