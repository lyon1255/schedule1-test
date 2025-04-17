using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x020000B3 RID: 179
	public static class TransformUtils : Il2CppSystem.Object
	{
		// Token: 0x06000D3B RID: 3387 RVA: 0x000087AA File Offset: 0x000069AA
		// Note: this type is marked as 'beforefieldinit'.
		static TransformUtils()
		{
			Il2CppClassPointerStore<TransformUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "TransformUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformUtils>.NativeClassPtr);
			TransformUtils.NativeMethodInfoPtr_GetWorldPacked_Public_Static_Packed_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformUtils>.NativeClassPtr, 100664914);
		}

		// Token: 0x06000D3C RID: 3388 RVA: 0x0009AC2C File Offset: 0x00098E2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84482, XrefRangeEnd = 84485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TransformUtils.Packed GetWorldPacked(this Transform self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformUtils.NativeMethodInfoPtr_GetWorldPacked_Public_Static_Packed_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D3D RID: 3389 RVA: 0x000087E3 File Offset: 0x000069E3
		public TransformUtils(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040008E5 RID: 2277
		private static readonly IntPtr NativeMethodInfoPtr_GetWorldPacked_Public_Static_Packed_Transform_0;

		// Token: 0x0200083B RID: 2107
		[StructLayout(2)]
		public struct Packed
		{
			// Token: 0x0600BF7A RID: 49018 RVA: 0x002EE8F4 File Offset: 0x002ECAF4
			// Note: this type is marked as 'beforefieldinit'.
			static Packed()
			{
				Il2CppClassPointerStore<TransformUtils.Packed>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TransformUtils>.NativeClassPtr, "Packed");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformUtils.Packed>.NativeClassPtr);
				TransformUtils.Packed.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformUtils.Packed>.NativeClassPtr, "position");
				TransformUtils.Packed.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformUtils.Packed>.NativeClassPtr, "rotation");
				TransformUtils.Packed.NativeFieldInfoPtr_lossyScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformUtils.Packed>.NativeClassPtr, "lossyScale");
				TransformUtils.Packed.NativeMethodInfoPtr_IsSame_Public_Boolean_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformUtils.Packed>.NativeClassPtr, 100664915);
			}

			// Token: 0x0600BF7B RID: 49019 RVA: 0x002EE970 File Offset: 0x002ECB70
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 84480, RefRangeEnd = 84482, XrefRangeStart = 84477, XrefRangeEnd = 84480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool IsSame(Transform transf)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transf);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformUtils.Packed.NativeMethodInfoPtr_IsSame_Public_Boolean_Transform_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BF7C RID: 49020 RVA: 0x0005D931 File Offset: 0x0005BB31
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TransformUtils.Packed>.NativeClassPtr, ref this));
			}

			// Token: 0x040081B1 RID: 33201
			private static readonly IntPtr NativeFieldInfoPtr_position;

			// Token: 0x040081B2 RID: 33202
			private static readonly IntPtr NativeFieldInfoPtr_rotation;

			// Token: 0x040081B3 RID: 33203
			private static readonly IntPtr NativeFieldInfoPtr_lossyScale;

			// Token: 0x040081B4 RID: 33204
			private static readonly IntPtr NativeMethodInfoPtr_IsSame_Public_Boolean_Transform_0;

			// Token: 0x040081B5 RID: 33205
			[FieldOffset(0)]
			public Vector3 position;

			// Token: 0x040081B6 RID: 33206
			[FieldOffset(12)]
			public Quaternion rotation;

			// Token: 0x040081B7 RID: 33207
			[FieldOffset(28)]
			public Vector3 lossyScale;
		}
	}
}
