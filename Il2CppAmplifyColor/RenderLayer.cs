using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppAmplifyColor
{
	// Token: 0x02000794 RID: 1940
	[Serializable]
	[StructLayout(2)]
	public struct RenderLayer
	{
		// Token: 0x0600B7C2 RID: 47042 RVA: 0x002D9C40 File Offset: 0x002D7E40
		// Note: this type is marked as 'beforefieldinit'.
		static RenderLayer()
		{
			Il2CppClassPointerStore<RenderLayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AmplifyColor", "RenderLayer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderLayer>.NativeClassPtr);
			RenderLayer.NativeFieldInfoPtr_mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderLayer>.NativeClassPtr, "mask");
			RenderLayer.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderLayer>.NativeClassPtr, "color");
			RenderLayer.NativeMethodInfoPtr__ctor_Public_Void_LayerMask_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderLayer>.NativeClassPtr, 100685874);
		}

		// Token: 0x0600B7C3 RID: 47043 RVA: 0x002D9CAC File Offset: 0x002D7EAC
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 312537, RefRangeEnd = 312548, XrefRangeStart = 312537, XrefRangeEnd = 312537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderLayer(LayerMask mask, Color color)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mask;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderLayer.NativeMethodInfoPtr__ctor_Public_Void_LayerMask_Color_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7C4 RID: 47044 RVA: 0x0005A399 File Offset: 0x00058599
		public Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderLayer>.NativeClassPtr, ref this));
		}

		// Token: 0x04007BD0 RID: 31696
		private static readonly IntPtr NativeFieldInfoPtr_mask;

		// Token: 0x04007BD1 RID: 31697
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x04007BD2 RID: 31698
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LayerMask_Color_0;

		// Token: 0x04007BD3 RID: 31699
		[FieldOffset(0)]
		public LayerMask mask;

		// Token: 0x04007BD4 RID: 31700
		[FieldOffset(4)]
		public Color color;
	}
}
