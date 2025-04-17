using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppVLB_Samples
{
	// Token: 0x020000BF RID: 191
	public class Rotater : MonoBehaviour
	{
		// Token: 0x06000E33 RID: 3635 RVA: 0x0009E1AC File Offset: 0x0009C3AC
		// Note: this type is marked as 'beforefieldinit'.
		static Rotater()
		{
			Il2CppClassPointerStore<Rotater>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB_Samples", "Rotater");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Rotater>.NativeClassPtr);
			Rotater.NativeFieldInfoPtr_EulerSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rotater>.NativeClassPtr, "EulerSpeed");
			Rotater.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rotater>.NativeClassPtr, 100665034);
			Rotater.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rotater>.NativeClassPtr, 100665035);
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x0009E218 File Offset: 0x0009C418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85678, XrefRangeEnd = 85686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rotater.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x0009E24C File Offset: 0x0009C44C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rotater() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Rotater>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rotater.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x00008DBB File Offset: 0x00006FBB
		public Rotater(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06000E37 RID: 3639 RVA: 0x0009E288 File Offset: 0x0009C488
		// (set) Token: 0x06000E38 RID: 3640 RVA: 0x00008DC4 File Offset: 0x00006FC4
		public unsafe Vector3 EulerSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rotater.NativeFieldInfoPtr_EulerSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rotater.NativeFieldInfoPtr_EulerSpeed)) = value;
			}
		}

		// Token: 0x0400098F RID: 2447
		private static readonly IntPtr NativeFieldInfoPtr_EulerSpeed;

		// Token: 0x04000990 RID: 2448
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000991 RID: 2449
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
