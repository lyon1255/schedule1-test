using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Animation
{
	// Token: 0x02000608 RID: 1544
	public class BoneTransform : Il2CppSystem.Object
	{
		// Token: 0x06008824 RID: 34852 RVA: 0x0023DC10 File Offset: 0x0023BE10
		// Note: this type is marked as 'beforefieldinit'.
		static BoneTransform()
		{
			Il2CppClassPointerStore<BoneTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Animation", "BoneTransform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoneTransform>.NativeClassPtr);
			BoneTransform.NativeFieldInfoPtr__Position_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneTransform>.NativeClassPtr, "<Position>k__BackingField");
			BoneTransform.NativeFieldInfoPtr__Rotation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneTransform>.NativeClassPtr, "<Rotation>k__BackingField");
			BoneTransform.NativeMethodInfoPtr_get_Position_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneTransform>.NativeClassPtr, 100680278);
			BoneTransform.NativeMethodInfoPtr_set_Position_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneTransform>.NativeClassPtr, 100680279);
			BoneTransform.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneTransform>.NativeClassPtr, 100680280);
			BoneTransform.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneTransform>.NativeClassPtr, 100680281);
			BoneTransform.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneTransform>.NativeClassPtr, 100680282);
		}

		// Token: 0x17002972 RID: 10610
		// (get) Token: 0x06008825 RID: 34853 RVA: 0x0023DCCC File Offset: 0x0023BECC
		// (set) Token: 0x06008826 RID: 34854 RVA: 0x0023DD08 File Offset: 0x0023BF08
		public unsafe Vector3 Position
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoneTransform.NativeMethodInfoPtr_get_Position_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoneTransform.NativeMethodInfoPtr_set_Position_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002973 RID: 10611
		// (get) Token: 0x06008827 RID: 34855 RVA: 0x0023DD48 File Offset: 0x0023BF48
		// (set) Token: 0x06008828 RID: 34856 RVA: 0x0023DD84 File Offset: 0x0023BF84
		public unsafe Quaternion Rotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoneTransform.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoneTransform.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008829 RID: 34857 RVA: 0x0023DDC4 File Offset: 0x0023BFC4
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoneTransform() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoneTransform>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoneTransform.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600882A RID: 34858 RVA: 0x00040E84 File Offset: 0x0003F084
		public BoneTransform(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002970 RID: 10608
		// (get) Token: 0x0600882B RID: 34859 RVA: 0x0023DE00 File Offset: 0x0023C000
		// (set) Token: 0x0600882C RID: 34860 RVA: 0x00040E8D File Offset: 0x0003F08D
		public unsafe Vector3 _Position_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoneTransform.NativeFieldInfoPtr__Position_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoneTransform.NativeFieldInfoPtr__Position_k__BackingField)) = value;
			}
		}

		// Token: 0x17002971 RID: 10609
		// (get) Token: 0x0600882D RID: 34861 RVA: 0x0023DE28 File Offset: 0x0023C028
		// (set) Token: 0x0600882E RID: 34862 RVA: 0x00040EA8 File Offset: 0x0003F0A8
		public unsafe Quaternion _Rotation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoneTransform.NativeFieldInfoPtr__Rotation_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoneTransform.NativeFieldInfoPtr__Rotation_k__BackingField)) = value;
			}
		}

		// Token: 0x04005C85 RID: 23685
		private static readonly IntPtr NativeFieldInfoPtr__Position_k__BackingField;

		// Token: 0x04005C86 RID: 23686
		private static readonly IntPtr NativeFieldInfoPtr__Rotation_k__BackingField;

		// Token: 0x04005C87 RID: 23687
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_get_Vector3_0;

		// Token: 0x04005C88 RID: 23688
		private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_set_Void_Vector3_0;

		// Token: 0x04005C89 RID: 23689
		private static readonly IntPtr NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0;

		// Token: 0x04005C8A RID: 23690
		private static readonly IntPtr NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0;

		// Token: 0x04005C8B RID: 23691
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
