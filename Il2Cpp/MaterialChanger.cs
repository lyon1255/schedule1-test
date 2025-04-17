using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000044 RID: 68
	public class MaterialChanger : MonoBehaviour
	{
		// Token: 0x060005BF RID: 1471 RVA: 0x00081870 File Offset: 0x0007FA70
		// Note: this type is marked as 'beforefieldinit'.
		static MaterialChanger()
		{
			Il2CppClassPointerStore<MaterialChanger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MaterialChanger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialChanger>.NativeClassPtr);
			MaterialChanger.NativeFieldInfoPtr__value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChanger>.NativeClassPtr, "_value");
			MaterialChanger.NativeFieldInfoPtr__changeMaterialSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChanger>.NativeClassPtr, "_changeMaterialSetting");
			MaterialChanger.NativeFieldInfoPtr__renderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChanger>.NativeClassPtr, "_renderers");
			MaterialChanger.NativeFieldInfoPtr__propBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChanger>.NativeClassPtr, "_propBlock");
			MaterialChanger.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChanger>.NativeClassPtr, 100663843);
			MaterialChanger.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChanger>.NativeClassPtr, 100663844);
			MaterialChanger.NativeMethodInfoPtr_FindAllMaterialInChild_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChanger>.NativeClassPtr, 100663845);
			MaterialChanger.NativeMethodInfoPtr_SetNewValueForAllMaterial_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChanger>.NativeClassPtr, 100663846);
			MaterialChanger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChanger>.NativeClassPtr, 100663847);
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00081954 File Offset: 0x0007FB54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75576, XrefRangeEnd = 75582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialChanger.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00081988 File Offset: 0x0007FB88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75582, XrefRangeEnd = 75596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialChanger.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x000819BC File Offset: 0x0007FBBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FindAllMaterialInChild()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialChanger.NativeMethodInfoPtr_FindAllMaterialInChild_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x000819F0 File Offset: 0x0007FBF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75596, XrefRangeEnd = 75605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNewValueForAllMaterial(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialChanger.NativeMethodInfoPtr_SetNewValueForAllMaterial_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00081A30 File Offset: 0x0007FC30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75605, XrefRangeEnd = 75610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaterialChanger() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialChanger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialChanger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x0000560C File Offset: 0x0000380C
		public MaterialChanger(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060005C6 RID: 1478 RVA: 0x00081A6C File Offset: 0x0007FC6C
		// (set) Token: 0x060005C7 RID: 1479 RVA: 0x00005615 File Offset: 0x00003815
		public unsafe float _value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialChanger.NativeFieldInfoPtr__value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialChanger.NativeFieldInfoPtr__value)) = value;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060005C8 RID: 1480 RVA: 0x00081A94 File Offset: 0x0007FC94
		// (set) Token: 0x060005C9 RID: 1481 RVA: 0x00005630 File Offset: 0x00003830
		public unsafe string _changeMaterialSetting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialChanger.NativeFieldInfoPtr__changeMaterialSetting);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialChanger.NativeFieldInfoPtr__changeMaterialSetting), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060005CA RID: 1482 RVA: 0x00081ABC File Offset: 0x0007FCBC
		// (set) Token: 0x060005CB RID: 1483 RVA: 0x0000564F File Offset: 0x0000384F
		public unsafe Il2CppReferenceArray<Renderer> _renderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialChanger.NativeFieldInfoPtr__renderers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Renderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialChanger.NativeFieldInfoPtr__renderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060005CC RID: 1484 RVA: 0x00081AEC File Offset: 0x0007FCEC
		// (set) Token: 0x060005CD RID: 1485 RVA: 0x0000566E File Offset: 0x0000386E
		public unsafe MaterialPropertyBlock _propBlock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialChanger.NativeFieldInfoPtr__propBlock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaterialPropertyBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialChanger.NativeFieldInfoPtr__propBlock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000370 RID: 880
		private static readonly IntPtr NativeFieldInfoPtr__value;

		// Token: 0x04000371 RID: 881
		private static readonly IntPtr NativeFieldInfoPtr__changeMaterialSetting;

		// Token: 0x04000372 RID: 882
		private static readonly IntPtr NativeFieldInfoPtr__renderers;

		// Token: 0x04000373 RID: 883
		private static readonly IntPtr NativeFieldInfoPtr__propBlock;

		// Token: 0x04000374 RID: 884
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000375 RID: 885
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000376 RID: 886
		private static readonly IntPtr NativeMethodInfoPtr_FindAllMaterialInChild_Private_Void_0;

		// Token: 0x04000377 RID: 887
		private static readonly IntPtr NativeMethodInfoPtr_SetNewValueForAllMaterial_Private_Void_Single_0;

		// Token: 0x04000378 RID: 888
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
