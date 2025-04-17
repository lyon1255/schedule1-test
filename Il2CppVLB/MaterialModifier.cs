using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x020000A1 RID: 161
	public static class MaterialModifier : Il2CppSystem.Object
	{
		// Token: 0x06000B14 RID: 2836 RVA: 0x00007ACA File Offset: 0x00005CCA
		// Note: this type is marked as 'beforefieldinit'.
		static MaterialModifier()
		{
			Il2CppClassPointerStore<MaterialModifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "MaterialModifier");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialModifier>.NativeClassPtr);
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x00007AEF File Offset: 0x00005CEF
		public MaterialModifier(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x02000828 RID: 2088
		public class Interface : Il2CppObjectBase
		{
			// Token: 0x0600BE92 RID: 48786 RVA: 0x002EC3D8 File Offset: 0x002EA5D8
			// Note: this type is marked as 'beforefieldinit'.
			static Interface()
			{
				Il2CppClassPointerStore<MaterialModifier.Interface>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialModifier>.NativeClassPtr, "Interface");
				MaterialModifier.Interface.NativeMethodInfoPtr_SetMaterialProp_Public_Abstract_Virtual_New_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialModifier.Interface>.NativeClassPtr, 100664588);
				MaterialModifier.Interface.NativeMethodInfoPtr_SetMaterialProp_Public_Abstract_Virtual_New_Void_Int32_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialModifier.Interface>.NativeClassPtr, 100664589);
				MaterialModifier.Interface.NativeMethodInfoPtr_SetMaterialProp_Public_Abstract_Virtual_New_Void_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialModifier.Interface>.NativeClassPtr, 100664590);
				MaterialModifier.Interface.NativeMethodInfoPtr_SetMaterialProp_Public_Abstract_Virtual_New_Void_Int32_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialModifier.Interface>.NativeClassPtr, 100664591);
				MaterialModifier.Interface.NativeMethodInfoPtr_SetMaterialProp_Public_Abstract_Virtual_New_Void_Int32_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialModifier.Interface>.NativeClassPtr, 100664592);
			}

			// Token: 0x0600BE93 RID: 48787 RVA: 0x002EC460 File Offset: 0x002EA660
			[CallerCount(0)]
			public unsafe virtual void SetMaterialProp(int nameID, float value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref nameID;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialModifier.Interface.NativeMethodInfoPtr_SetMaterialProp_Public_Abstract_Virtual_New_Void_Int32_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BE94 RID: 48788 RVA: 0x002EC4B8 File Offset: 0x002EA6B8
			[CallerCount(0)]
			public unsafe virtual void SetMaterialProp(int nameID, Vector4 value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref nameID;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialModifier.Interface.NativeMethodInfoPtr_SetMaterialProp_Public_Abstract_Virtual_New_Void_Int32_Vector4_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BE95 RID: 48789 RVA: 0x002EC510 File Offset: 0x002EA710
			[CallerCount(0)]
			public unsafe virtual void SetMaterialProp(int nameID, Color value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref nameID;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialModifier.Interface.NativeMethodInfoPtr_SetMaterialProp_Public_Abstract_Virtual_New_Void_Int32_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BE96 RID: 48790 RVA: 0x002EC568 File Offset: 0x002EA768
			[CallerCount(0)]
			public unsafe virtual void SetMaterialProp(int nameID, Matrix4x4 value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref nameID;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialModifier.Interface.NativeMethodInfoPtr_SetMaterialProp_Public_Abstract_Virtual_New_Void_Int32_Matrix4x4_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BE97 RID: 48791 RVA: 0x002EC5C0 File Offset: 0x002EA7C0
			[CallerCount(0)]
			public unsafe virtual void SetMaterialProp(int nameID, Texture value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref nameID;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialModifier.Interface.NativeMethodInfoPtr_SetMaterialProp_Public_Abstract_Virtual_New_Void_Int32_Texture_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BE98 RID: 48792 RVA: 0x0005D300 File Offset: 0x0005B500
			public Interface(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400811F RID: 33055
			private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProp_Public_Abstract_Virtual_New_Void_Int32_Single_0;

			// Token: 0x04008120 RID: 33056
			private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProp_Public_Abstract_Virtual_New_Void_Int32_Vector4_0;

			// Token: 0x04008121 RID: 33057
			private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProp_Public_Abstract_Virtual_New_Void_Int32_Color_0;

			// Token: 0x04008122 RID: 33058
			private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProp_Public_Abstract_Virtual_New_Void_Int32_Matrix4x4_0;

			// Token: 0x04008123 RID: 33059
			private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProp_Public_Abstract_Virtual_New_Void_Int32_Texture_0;
		}

		// Token: 0x02000829 RID: 2089
		public sealed class Callback : MulticastDelegate
		{
			// Token: 0x0600BE99 RID: 48793 RVA: 0x002EC61C File Offset: 0x002EA81C
			// Note: this type is marked as 'beforefieldinit'.
			static Callback()
			{
				Il2CppClassPointerStore<MaterialModifier.Callback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialModifier>.NativeClassPtr, "Callback");
				MaterialModifier.Callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialModifier.Callback>.NativeClassPtr, 100664593);
				MaterialModifier.Callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Interface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialModifier.Callback>.NativeClassPtr, 100664594);
				MaterialModifier.Callback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Interface_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialModifier.Callback>.NativeClassPtr, 100664595);
				MaterialModifier.Callback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialModifier.Callback>.NativeClassPtr, 100664596);
			}

			// Token: 0x0600BE9A RID: 48794 RVA: 0x002EC690 File Offset: 0x002EA890
			[CallerCount(632)]
			[CachedScanResults(RefRangeStart = 81883, RefRangeEnd = 82515, XrefRangeStart = 81874, XrefRangeEnd = 81883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Callback(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialModifier.Callback>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialModifier.Callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BE9B RID: 48795 RVA: 0x002EC6EC File Offset: 0x002EA8EC
			[CallerCount(0)]
			public unsafe void Invoke(MaterialModifier.Interface owner)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialModifier.Callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Interface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BE9C RID: 48796 RVA: 0x002EC730 File Offset: 0x002EA930
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 74821, RefRangeEnd = 74822, XrefRangeStart = 74821, XrefRangeEnd = 74822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(MaterialModifier.Interface owner, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialModifier.Callback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Interface_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600BE9D RID: 48797 RVA: 0x002EC7A4 File Offset: 0x002EA9A4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22498, RefRangeEnd = 22499, XrefRangeStart = 22498, XrefRangeEnd = 22499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialModifier.Callback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BE9E RID: 48798 RVA: 0x0005D309 File Offset: 0x0005B509
			public Callback(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600BE9F RID: 48799 RVA: 0x0005D312 File Offset: 0x0005B512
			public static implicit operator MaterialModifier.Callback(Action<MaterialModifier.Interface> A_0)
			{
				return DelegateSupport.ConvertDelegate<MaterialModifier.Callback>(A_0);
			}

			// Token: 0x0600BEA0 RID: 48800 RVA: 0x0005D31A File Offset: 0x0005B51A
			public static MaterialModifier.Callback operator +(MaterialModifier.Callback A_0, MaterialModifier.Callback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<MaterialModifier.Callback>();
			}

			// Token: 0x0600BEA1 RID: 48801 RVA: 0x0005D328 File Offset: 0x0005B528
			public static MaterialModifier.Callback operator -(MaterialModifier.Callback A_0, MaterialModifier.Callback A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<MaterialModifier.Callback>();
				}
				return result;
			}

			// Token: 0x04008124 RID: 33060
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04008125 RID: 33061
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Interface_0;

			// Token: 0x04008126 RID: 33062
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Interface_AsyncCallback_Object_0;

			// Token: 0x04008127 RID: 33063
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
