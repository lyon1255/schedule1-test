using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000028 RID: 40
	public class RotateAround : MonoBehaviour
	{
		// Token: 0x060002D2 RID: 722 RVA: 0x000792A0 File Offset: 0x000774A0
		// Note: this type is marked as 'beforefieldinit'.
		static RotateAround()
		{
			Il2CppClassPointerStore<RotateAround>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "RotateAround");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RotateAround>.NativeClassPtr);
			RotateAround.NativeFieldInfoPtr_rot_center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateAround>.NativeClassPtr, "rot_center");
			RotateAround.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateAround>.NativeClassPtr, 100663560);
			RotateAround.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateAround>.NativeClassPtr, 100663561);
			RotateAround.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateAround>.NativeClassPtr, 100663562);
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00079320 File Offset: 0x00077520
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotateAround.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00079354 File Offset: 0x00077554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72774, XrefRangeEnd = 72779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotateAround.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00079388 File Offset: 0x00077588
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RotateAround() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RotateAround>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotateAround.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00003989 File Offset: 0x00001B89
		public RotateAround(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x000793C4 File Offset: 0x000775C4
		// (set) Token: 0x060002D8 RID: 728 RVA: 0x00003992 File Offset: 0x00001B92
		public unsafe Transform rot_center
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateAround.NativeFieldInfoPtr_rot_center);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateAround.NativeFieldInfoPtr_rot_center), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeFieldInfoPtr_rot_center;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
