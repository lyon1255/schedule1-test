using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200066E RID: 1646
	public class UIMover : MonoBehaviour
	{
		// Token: 0x060092E9 RID: 37609 RVA: 0x0025DA90 File Offset: 0x0025BC90
		// Note: this type is marked as 'beforefieldinit'.
		static UIMover()
		{
			Il2CppClassPointerStore<UIMover>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "UIMover");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIMover>.NativeClassPtr);
			UIMover.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIMover>.NativeClassPtr, "Rect");
			UIMover.NativeFieldInfoPtr_MinSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIMover>.NativeClassPtr, "MinSpeed");
			UIMover.NativeFieldInfoPtr_MaxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIMover>.NativeClassPtr, "MaxSpeed");
			UIMover.NativeFieldInfoPtr_SpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIMover>.NativeClassPtr, "SpeedMultiplier");
			UIMover.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIMover>.NativeClassPtr, "speed");
			UIMover.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIMover>.NativeClassPtr, 100681523);
			UIMover.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIMover>.NativeClassPtr, 100681524);
			UIMover.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIMover>.NativeClassPtr, 100681525);
		}

		// Token: 0x060092EA RID: 37610 RVA: 0x0025DB60 File Offset: 0x0025BD60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264831, XrefRangeEnd = 264833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIMover.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092EB RID: 37611 RVA: 0x0025DB94 File Offset: 0x0025BD94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264833, XrefRangeEnd = 264837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIMover.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092EC RID: 37612 RVA: 0x0025DBC8 File Offset: 0x0025BDC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264837, XrefRangeEnd = 264844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIMover() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIMover>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIMover.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092ED RID: 37613 RVA: 0x00047217 File Offset: 0x00045417
		public UIMover(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D07 RID: 11527
		// (get) Token: 0x060092EE RID: 37614 RVA: 0x0025DC04 File Offset: 0x0025BE04
		// (set) Token: 0x060092EF RID: 37615 RVA: 0x00047220 File Offset: 0x00045420
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMover.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMover.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D08 RID: 11528
		// (get) Token: 0x060092F0 RID: 37616 RVA: 0x0025DC34 File Offset: 0x0025BE34
		// (set) Token: 0x060092F1 RID: 37617 RVA: 0x0004723F File Offset: 0x0004543F
		public unsafe Vector2 MinSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMover.NativeFieldInfoPtr_MinSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMover.NativeFieldInfoPtr_MinSpeed)) = value;
			}
		}

		// Token: 0x17002D09 RID: 11529
		// (get) Token: 0x060092F2 RID: 37618 RVA: 0x0025DC5C File Offset: 0x0025BE5C
		// (set) Token: 0x060092F3 RID: 37619 RVA: 0x0004725A File Offset: 0x0004545A
		public unsafe Vector2 MaxSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMover.NativeFieldInfoPtr_MaxSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMover.NativeFieldInfoPtr_MaxSpeed)) = value;
			}
		}

		// Token: 0x17002D0A RID: 11530
		// (get) Token: 0x060092F4 RID: 37620 RVA: 0x0025DC84 File Offset: 0x0025BE84
		// (set) Token: 0x060092F5 RID: 37621 RVA: 0x00047275 File Offset: 0x00045475
		public unsafe float SpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMover.NativeFieldInfoPtr_SpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMover.NativeFieldInfoPtr_SpeedMultiplier)) = value;
			}
		}

		// Token: 0x17002D0B RID: 11531
		// (get) Token: 0x060092F6 RID: 37622 RVA: 0x0025DCAC File Offset: 0x0025BEAC
		// (set) Token: 0x060092F7 RID: 37623 RVA: 0x00047290 File Offset: 0x00045490
		public unsafe Vector2 speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMover.NativeFieldInfoPtr_speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMover.NativeFieldInfoPtr_speed)) = value;
			}
		}

		// Token: 0x04006336 RID: 25398
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x04006337 RID: 25399
		private static readonly IntPtr NativeFieldInfoPtr_MinSpeed;

		// Token: 0x04006338 RID: 25400
		private static readonly IntPtr NativeFieldInfoPtr_MaxSpeed;

		// Token: 0x04006339 RID: 25401
		private static readonly IntPtr NativeFieldInfoPtr_SpeedMultiplier;

		// Token: 0x0400633A RID: 25402
		private static readonly IntPtr NativeFieldInfoPtr_speed;

		// Token: 0x0400633B RID: 25403
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400633C RID: 25404
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x0400633D RID: 25405
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
