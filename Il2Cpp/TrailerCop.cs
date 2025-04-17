using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using Il2CppScheduleOne.Police;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200001D RID: 29
	public class TrailerCop : MonoBehaviour
	{
		// Token: 0x060001BF RID: 447 RVA: 0x000760D8 File Offset: 0x000742D8
		// Note: this type is marked as 'beforefieldinit'.
		static TrailerCop()
		{
			Il2CppClassPointerStore<TrailerCop>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "TrailerCop");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrailerCop>.NativeClassPtr);
			TrailerCop.NativeFieldInfoPtr_Officer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailerCop>.NativeClassPtr, "Officer");
			TrailerCop.NativeFieldInfoPtr_StartPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailerCop>.NativeClassPtr, "StartPoint");
			TrailerCop.NativeFieldInfoPtr_EndPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailerCop>.NativeClassPtr, "EndPoint");
			TrailerCop.NativeFieldInfoPtr_FaceTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailerCop>.NativeClassPtr, "FaceTarget");
			TrailerCop.NativeFieldInfoPtr_Equippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailerCop>.NativeClassPtr, "Equippable");
			TrailerCop.NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailerCop>.NativeClassPtr, "Speed");
			TrailerCop.NativeFieldInfoPtr_RaiseWeapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailerCop>.NativeClassPtr, "RaiseWeapon");
			TrailerCop.NativeFieldInfoPtr_ShootTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailerCop>.NativeClassPtr, "ShootTarget");
			TrailerCop.NativeMethodInfoPtr_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailerCop>.NativeClassPtr, 100663465);
			TrailerCop.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailerCop>.NativeClassPtr, 100663466);
			TrailerCop.NativeMethodInfoPtr_Shoot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailerCop>.NativeClassPtr, 100663467);
			TrailerCop.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailerCop>.NativeClassPtr, 100663468);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x000761F8 File Offset: 0x000743F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72258, XrefRangeEnd = 72276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailerCop.NativeMethodInfoPtr_Play_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0007622C File Offset: 0x0007442C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72276, XrefRangeEnd = 72279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailerCop.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00076260 File Offset: 0x00074460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72279, XrefRangeEnd = 72283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Shoot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailerCop.NativeMethodInfoPtr_Shoot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00076294 File Offset: 0x00074494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72283, XrefRangeEnd = 72284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrailerCop() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrailerCop>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailerCop.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00002F31 File Offset: 0x00001131
		public TrailerCop(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x000762D0 File Offset: 0x000744D0
		// (set) Token: 0x060001C6 RID: 454 RVA: 0x00002F3A File Offset: 0x0000113A
		public unsafe PoliceOfficer Officer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerCop.NativeFieldInfoPtr_Officer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceOfficer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerCop.NativeFieldInfoPtr_Officer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x00076300 File Offset: 0x00074500
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x00002F59 File Offset: 0x00001159
		public unsafe Transform StartPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerCop.NativeFieldInfoPtr_StartPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerCop.NativeFieldInfoPtr_StartPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x00076330 File Offset: 0x00074530
		// (set) Token: 0x060001CA RID: 458 RVA: 0x00002F78 File Offset: 0x00001178
		public unsafe Transform EndPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerCop.NativeFieldInfoPtr_EndPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerCop.NativeFieldInfoPtr_EndPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001CB RID: 459 RVA: 0x00076360 File Offset: 0x00074560
		// (set) Token: 0x060001CC RID: 460 RVA: 0x00002F97 File Offset: 0x00001197
		public unsafe Transform FaceTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerCop.NativeFieldInfoPtr_FaceTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerCop.NativeFieldInfoPtr_FaceTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001CD RID: 461 RVA: 0x00076390 File Offset: 0x00074590
		// (set) Token: 0x060001CE RID: 462 RVA: 0x00002FB6 File Offset: 0x000011B6
		public unsafe AvatarEquippable Equippable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerCop.NativeFieldInfoPtr_Equippable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerCop.NativeFieldInfoPtr_Equippable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001CF RID: 463 RVA: 0x000763C0 File Offset: 0x000745C0
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x00002FD5 File Offset: 0x000011D5
		public unsafe float Speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerCop.NativeFieldInfoPtr_Speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerCop.NativeFieldInfoPtr_Speed)) = value;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x000763E8 File Offset: 0x000745E8
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x00002FF0 File Offset: 0x000011F0
		public unsafe bool RaiseWeapon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerCop.NativeFieldInfoPtr_RaiseWeapon);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerCop.NativeFieldInfoPtr_RaiseWeapon)) = value;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x00076410 File Offset: 0x00074610
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x0000300B File Offset: 0x0000120B
		public unsafe Transform ShootTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerCop.NativeFieldInfoPtr_ShootTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerCop.NativeFieldInfoPtr_ShootTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeFieldInfoPtr_Officer;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeFieldInfoPtr_StartPoint;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeFieldInfoPtr_EndPoint;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeFieldInfoPtr_FaceTarget;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeFieldInfoPtr_Equippable;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeFieldInfoPtr_Speed;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeFieldInfoPtr_RaiseWeapon;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeFieldInfoPtr_ShootTarget;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_0;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeMethodInfoPtr_Shoot_Public_Void_0;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
