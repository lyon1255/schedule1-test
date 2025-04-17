using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000019 RID: 25
	public class Rotate : MonoBehaviour
	{
		// Token: 0x06000198 RID: 408 RVA: 0x000759F8 File Offset: 0x00073BF8
		// Note: this type is marked as 'beforefieldinit'.
		static Rotate()
		{
			Il2CppClassPointerStore<Rotate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Rotate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Rotate>.NativeClassPtr);
			Rotate.NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rotate>.NativeClassPtr, "Speed");
			Rotate.NativeFieldInfoPtr_Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rotate>.NativeClassPtr, "Axis");
			Rotate.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rotate>.NativeClassPtr, 100663446);
			Rotate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rotate>.NativeClassPtr, 100663447);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00075A78 File Offset: 0x00073C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72154, XrefRangeEnd = 72157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rotate.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00075AAC File Offset: 0x00073CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72157, XrefRangeEnd = 72160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rotate() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Rotate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rotate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00002E02 File Offset: 0x00001002
		public Rotate(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600019C RID: 412 RVA: 0x00075AE8 File Offset: 0x00073CE8
		// (set) Token: 0x0600019D RID: 413 RVA: 0x00002E0B File Offset: 0x0000100B
		public unsafe float Speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rotate.NativeFieldInfoPtr_Speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rotate.NativeFieldInfoPtr_Speed)) = value;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600019E RID: 414 RVA: 0x00075B10 File Offset: 0x00073D10
		// (set) Token: 0x0600019F RID: 415 RVA: 0x00002E26 File Offset: 0x00001026
		public unsafe Vector3 Axis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rotate.NativeFieldInfoPtr_Axis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rotate.NativeFieldInfoPtr_Axis)) = value;
			}
		}

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeFieldInfoPtr_Speed;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeFieldInfoPtr_Axis;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
