using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppStylizedGrassDemo
{
	// Token: 0x020000C3 RID: 195
	public class MoveInCircle : MonoBehaviour
	{
		// Token: 0x06000E86 RID: 3718 RVA: 0x0009ED60 File Offset: 0x0009CF60
		// Note: this type is marked as 'beforefieldinit'.
		static MoveInCircle()
		{
			Il2CppClassPointerStore<MoveInCircle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "StylizedGrassDemo", "MoveInCircle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveInCircle>.NativeClassPtr);
			MoveInCircle.NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveInCircle>.NativeClassPtr, "radius");
			MoveInCircle.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveInCircle>.NativeClassPtr, "speed");
			MoveInCircle.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveInCircle>.NativeClassPtr, "offset");
			MoveInCircle.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveInCircle>.NativeClassPtr, 100665045);
			MoveInCircle.NativeMethodInfoPtr_Move_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveInCircle>.NativeClassPtr, 100665046);
			MoveInCircle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveInCircle>.NativeClassPtr, 100665047);
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x0009EE08 File Offset: 0x0009D008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85797, XrefRangeEnd = 85805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveInCircle.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x0009EE3C File Offset: 0x0009D03C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Move()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveInCircle.NativeMethodInfoPtr_Move_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x0009EE70 File Offset: 0x0009D070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85805, XrefRangeEnd = 85806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoveInCircle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveInCircle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveInCircle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x00009157 File Offset: 0x00007357
		public MoveInCircle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06000E8B RID: 3723 RVA: 0x0009EEAC File Offset: 0x0009D0AC
		// (set) Token: 0x06000E8C RID: 3724 RVA: 0x00009160 File Offset: 0x00007360
		public unsafe float radius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveInCircle.NativeFieldInfoPtr_radius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveInCircle.NativeFieldInfoPtr_radius)) = value;
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06000E8D RID: 3725 RVA: 0x0009EED4 File Offset: 0x0009D0D4
		// (set) Token: 0x06000E8E RID: 3726 RVA: 0x0000917B File Offset: 0x0000737B
		public unsafe float speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveInCircle.NativeFieldInfoPtr_speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveInCircle.NativeFieldInfoPtr_speed)) = value;
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000E8F RID: 3727 RVA: 0x0009EEFC File Offset: 0x0009D0FC
		// (set) Token: 0x06000E90 RID: 3728 RVA: 0x00009196 File Offset: 0x00007396
		public unsafe Vector3 offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveInCircle.NativeFieldInfoPtr_offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveInCircle.NativeFieldInfoPtr_offset)) = value;
			}
		}

		// Token: 0x040009BA RID: 2490
		private static readonly IntPtr NativeFieldInfoPtr_radius;

		// Token: 0x040009BB RID: 2491
		private static readonly IntPtr NativeFieldInfoPtr_speed;

		// Token: 0x040009BC RID: 2492
		private static readonly IntPtr NativeFieldInfoPtr_offset;

		// Token: 0x040009BD RID: 2493
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040009BE RID: 2494
		private static readonly IntPtr NativeMethodInfoPtr_Move_Private_Void_0;

		// Token: 0x040009BF RID: 2495
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
