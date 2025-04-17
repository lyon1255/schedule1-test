using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Rendering;

namespace Il2CppVLB
{
	// Token: 0x020000A0 RID: 160
	public static class MaterialManager : Il2CppSystem.Object
	{
		// Token: 0x06000AFB RID: 2811 RVA: 0x000930CC File Offset: 0x000912CC
		// Note: this type is marked as 'beforefieldinit'.
		static MaterialManager()
		{
			Il2CppClassPointerStore<MaterialManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "MaterialManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr);
			MaterialManager.NativeFieldInfoPtr_materialPropertyBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, "materialPropertyBlock");
			MaterialManager.NativeFieldInfoPtr_BlendingMode_SrcFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, "BlendingMode_SrcFactor");
			MaterialManager.NativeFieldInfoPtr_BlendingMode_DstFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, "BlendingMode_DstFactor");
			MaterialManager.NativeFieldInfoPtr_BlendingMode_AlphaAsBlack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, "BlendingMode_AlphaAsBlack");
			MaterialManager.NativeFieldInfoPtr_ms_MaterialsGroupSD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, "ms_MaterialsGroupSD");
			MaterialManager.NativeFieldInfoPtr_ms_MaterialsGroupHD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, "ms_MaterialsGroupHD");
			MaterialManager.NativeMethodInfoPtr_NewMaterialPersistent_Public_Static_Material_Shader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, 100664547);
			MaterialManager.NativeMethodInfoPtr_GetInstancedMaterial_Public_Static_Material_UInt32_byref_StaticPropertiesSD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, 100664548);
			MaterialManager.NativeMethodInfoPtr_GetInstancedMaterial_Public_Static_Material_UInt32_byref_StaticPropertiesHD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, 100664549);
			MaterialManager.NativeMethodInfoPtr_GetInstancedMaterial_Private_Static_Material_Hashtable_UInt32_byref_IStaticProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, 100664550);
			MaterialManager.NativeMethodInfoPtr_SetBlendingMode_Private_Static_Void_Material_Int32_BlendMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, 100664551);
			MaterialManager.NativeMethodInfoPtr_SetStencilRef_Private_Static_Void_Material_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, 100664552);
			MaterialManager.NativeMethodInfoPtr_SetStencilComp_Private_Static_Void_Material_Int32_CompareFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, 100664553);
			MaterialManager.NativeMethodInfoPtr_SetStencilOp_Private_Static_Void_Material_Int32_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, 100664554);
			MaterialManager.NativeMethodInfoPtr_SetCull_Private_Static_Void_Material_Int32_CullMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, 100664555);
			MaterialManager.NativeMethodInfoPtr_SetZWrite_Private_Static_Void_Material_Int32_ZWrite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, 100664556);
			MaterialManager.NativeMethodInfoPtr_SetZTest_Private_Static_Void_Material_Int32_CompareFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, 100664557);
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x00093250 File Offset: 0x00091450
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 81769, RefRangeEnd = 81771, XrefRangeStart = 81758, XrefRangeEnd = 81769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material NewMaterialPersistent(Shader shader, bool gpuInstanced)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(shader);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gpuInstanced;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.NativeMethodInfoPtr_NewMaterialPersistent_Public_Static_Material_Shader_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x000932A4 File Offset: 0x000914A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81771, XrefRangeEnd = 81779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material GetInstancedMaterial(uint groupID, ref MaterialManager.StaticPropertiesSD staticProps)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref groupID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &staticProps;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.NativeMethodInfoPtr_GetInstancedMaterial_Public_Static_Material_UInt32_byref_StaticPropertiesSD_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x000932F4 File Offset: 0x000914F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81787, RefRangeEnd = 81788, XrefRangeStart = 81779, XrefRangeEnd = 81787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material GetInstancedMaterial(uint groupID, ref MaterialManager.StaticPropertiesHD staticProps)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref groupID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &staticProps;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.NativeMethodInfoPtr_GetInstancedMaterial_Public_Static_Material_UInt32_byref_StaticPropertiesHD_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x00093344 File Offset: 0x00091544
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 81823, RefRangeEnd = 81826, XrefRangeStart = 81788, XrefRangeEnd = 81823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material GetInstancedMaterial(Hashtable groups, uint groupID, ref MaterialManager.IStaticProperties staticProps)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(groups);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref groupID;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(staticProps);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MaterialManager.NativeMethodInfoPtr_GetInstancedMaterial_Private_Static_Material_Hashtable_UInt32_byref_IStaticProperties_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			staticProps = ((intPtr4 == 0) ? null : new MaterialManager.IStaticProperties(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Material>(intPtr5) : null;
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x000933C0 File Offset: 0x000915C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81826, XrefRangeEnd = 81874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetBlendingMode(this Material mat, int nameID, BlendMode value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.NativeMethodInfoPtr_SetBlendingMode_Private_Static_Void_Material_Int32_BlendMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x00093414 File Offset: 0x00091614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetStencilRef(this Material mat, int nameID, int value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.NativeMethodInfoPtr_SetStencilRef_Private_Static_Void_Material_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x00093468 File Offset: 0x00091668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetStencilComp(this Material mat, int nameID, CompareFunction value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.NativeMethodInfoPtr_SetStencilComp_Private_Static_Void_Material_Int32_CompareFunction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x000934BC File Offset: 0x000916BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetStencilOp(this Material mat, int nameID, StencilOp value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.NativeMethodInfoPtr_SetStencilOp_Private_Static_Void_Material_Int32_StencilOp_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x00093510 File Offset: 0x00091710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetCull(this Material mat, int nameID, CullMode value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.NativeMethodInfoPtr_SetCull_Private_Static_Void_Material_Int32_CullMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x00093564 File Offset: 0x00091764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetZWrite(this Material mat, int nameID, MaterialManager.ZWrite value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.NativeMethodInfoPtr_SetZWrite_Private_Static_Void_Material_Int32_ZWrite_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x000935B8 File Offset: 0x000917B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetZTest(this Material mat, int nameID, CompareFunction value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.NativeMethodInfoPtr_SetZTest_Private_Static_Void_Material_Int32_CompareFunction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x00007A55 File Offset: 0x00005C55
		public MaterialManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000B08 RID: 2824 RVA: 0x0009360C File Offset: 0x0009180C
		// (set) Token: 0x06000B09 RID: 2825 RVA: 0x00007A5E File Offset: 0x00005C5E
		public unsafe static MaterialPropertyBlock materialPropertyBlock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MaterialManager.NativeFieldInfoPtr_materialPropertyBlock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaterialPropertyBlock>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MaterialManager.NativeFieldInfoPtr_materialPropertyBlock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000B0A RID: 2826 RVA: 0x00093634 File Offset: 0x00091834
		// (set) Token: 0x06000B0B RID: 2827 RVA: 0x00007A70 File Offset: 0x00005C70
		public unsafe static Il2CppStructArray<BlendMode> BlendingMode_SrcFactor
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MaterialManager.NativeFieldInfoPtr_BlendingMode_SrcFactor, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<BlendMode>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MaterialManager.NativeFieldInfoPtr_BlendingMode_SrcFactor, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000B0C RID: 2828 RVA: 0x0009365C File Offset: 0x0009185C
		// (set) Token: 0x06000B0D RID: 2829 RVA: 0x00007A82 File Offset: 0x00005C82
		public unsafe static Il2CppStructArray<BlendMode> BlendingMode_DstFactor
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MaterialManager.NativeFieldInfoPtr_BlendingMode_DstFactor, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<BlendMode>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MaterialManager.NativeFieldInfoPtr_BlendingMode_DstFactor, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000B0E RID: 2830 RVA: 0x00093684 File Offset: 0x00091884
		// (set) Token: 0x06000B0F RID: 2831 RVA: 0x00007A94 File Offset: 0x00005C94
		public unsafe static Il2CppStructArray<bool> BlendingMode_AlphaAsBlack
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MaterialManager.NativeFieldInfoPtr_BlendingMode_AlphaAsBlack, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MaterialManager.NativeFieldInfoPtr_BlendingMode_AlphaAsBlack, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000B10 RID: 2832 RVA: 0x000936AC File Offset: 0x000918AC
		// (set) Token: 0x06000B11 RID: 2833 RVA: 0x00007AA6 File Offset: 0x00005CA6
		public unsafe static Hashtable ms_MaterialsGroupSD
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MaterialManager.NativeFieldInfoPtr_ms_MaterialsGroupSD, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MaterialManager.NativeFieldInfoPtr_ms_MaterialsGroupSD, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000B12 RID: 2834 RVA: 0x000936D4 File Offset: 0x000918D4
		// (set) Token: 0x06000B13 RID: 2835 RVA: 0x00007AB8 File Offset: 0x00005CB8
		public unsafe static Hashtable ms_MaterialsGroupHD
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MaterialManager.NativeFieldInfoPtr_ms_MaterialsGroupHD, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MaterialManager.NativeFieldInfoPtr_ms_MaterialsGroupHD, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400074B RID: 1867
		private static readonly IntPtr NativeFieldInfoPtr_materialPropertyBlock;

		// Token: 0x0400074C RID: 1868
		private static readonly IntPtr NativeFieldInfoPtr_BlendingMode_SrcFactor;

		// Token: 0x0400074D RID: 1869
		private static readonly IntPtr NativeFieldInfoPtr_BlendingMode_DstFactor;

		// Token: 0x0400074E RID: 1870
		private static readonly IntPtr NativeFieldInfoPtr_BlendingMode_AlphaAsBlack;

		// Token: 0x0400074F RID: 1871
		private static readonly IntPtr NativeFieldInfoPtr_ms_MaterialsGroupSD;

		// Token: 0x04000750 RID: 1872
		private static readonly IntPtr NativeFieldInfoPtr_ms_MaterialsGroupHD;

		// Token: 0x04000751 RID: 1873
		private static readonly IntPtr NativeMethodInfoPtr_NewMaterialPersistent_Public_Static_Material_Shader_Boolean_0;

		// Token: 0x04000752 RID: 1874
		private static readonly IntPtr NativeMethodInfoPtr_GetInstancedMaterial_Public_Static_Material_UInt32_byref_StaticPropertiesSD_0;

		// Token: 0x04000753 RID: 1875
		private static readonly IntPtr NativeMethodInfoPtr_GetInstancedMaterial_Public_Static_Material_UInt32_byref_StaticPropertiesHD_0;

		// Token: 0x04000754 RID: 1876
		private static readonly IntPtr NativeMethodInfoPtr_GetInstancedMaterial_Private_Static_Material_Hashtable_UInt32_byref_IStaticProperties_0;

		// Token: 0x04000755 RID: 1877
		private static readonly IntPtr NativeMethodInfoPtr_SetBlendingMode_Private_Static_Void_Material_Int32_BlendMode_0;

		// Token: 0x04000756 RID: 1878
		private static readonly IntPtr NativeMethodInfoPtr_SetStencilRef_Private_Static_Void_Material_Int32_Int32_0;

		// Token: 0x04000757 RID: 1879
		private static readonly IntPtr NativeMethodInfoPtr_SetStencilComp_Private_Static_Void_Material_Int32_CompareFunction_0;

		// Token: 0x04000758 RID: 1880
		private static readonly IntPtr NativeMethodInfoPtr_SetStencilOp_Private_Static_Void_Material_Int32_StencilOp_0;

		// Token: 0x04000759 RID: 1881
		private static readonly IntPtr NativeMethodInfoPtr_SetCull_Private_Static_Void_Material_Int32_CullMode_0;

		// Token: 0x0400075A RID: 1882
		private static readonly IntPtr NativeMethodInfoPtr_SetZWrite_Private_Static_Void_Material_Int32_ZWrite_0;

		// Token: 0x0400075B RID: 1883
		private static readonly IntPtr NativeMethodInfoPtr_SetZTest_Private_Static_Void_Material_Int32_CompareFunction_0;

		// Token: 0x0200081E RID: 2078
		[OriginalName("Assembly-CSharp.dll", "", "BlendingMode")]
		public enum BlendingMode
		{
			// Token: 0x040080D5 RID: 32981
			Additive,
			// Token: 0x040080D6 RID: 32982
			SoftAdditive,
			// Token: 0x040080D7 RID: 32983
			TraditionalTransparency,
			// Token: 0x040080D8 RID: 32984
			Count
		}

		// Token: 0x0200081F RID: 2079
		[OriginalName("Assembly-CSharp.dll", "", "ColorGradient")]
		public enum ColorGradient
		{
			// Token: 0x040080DA RID: 32986
			Off,
			// Token: 0x040080DB RID: 32987
			MatrixLow,
			// Token: 0x040080DC RID: 32988
			MatrixHigh,
			// Token: 0x040080DD RID: 32989
			Count
		}

		// Token: 0x02000820 RID: 2080
		[OriginalName("Assembly-CSharp.dll", "", "Noise3D")]
		public enum Noise3D
		{
			// Token: 0x040080DF RID: 32991
			Off,
			// Token: 0x040080E0 RID: 32992
			On,
			// Token: 0x040080E1 RID: 32993
			Count
		}

		// Token: 0x02000821 RID: 2081
		public static class SD : Il2CppSystem.Object
		{
			// Token: 0x0600BE67 RID: 48743 RVA: 0x0005D259 File Offset: 0x0005B459
			// Note: this type is marked as 'beforefieldinit'.
			static SD()
			{
				Il2CppClassPointerStore<MaterialManager.SD>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, "SD");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialManager.SD>.NativeClassPtr);
			}

			// Token: 0x0600BE68 RID: 48744 RVA: 0x0005D279 File Offset: 0x0005B479
			public SD(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x02000C23 RID: 3107
			[OriginalName("Assembly-CSharp.dll", "", "DepthBlend")]
			public enum DepthBlend
			{
				// Token: 0x0400968B RID: 38539
				Off,
				// Token: 0x0400968C RID: 38540
				On,
				// Token: 0x0400968D RID: 38541
				Count
			}

			// Token: 0x02000C24 RID: 3108
			[OriginalName("Assembly-CSharp.dll", "", "DynamicOcclusion")]
			public enum DynamicOcclusion
			{
				// Token: 0x0400968F RID: 38543
				Off,
				// Token: 0x04009690 RID: 38544
				ClippingPlane,
				// Token: 0x04009691 RID: 38545
				DepthTexture,
				// Token: 0x04009692 RID: 38546
				Count
			}

			// Token: 0x02000C25 RID: 3109
			[OriginalName("Assembly-CSharp.dll", "", "MeshSkewing")]
			public enum MeshSkewing
			{
				// Token: 0x04009694 RID: 38548
				Off,
				// Token: 0x04009695 RID: 38549
				On,
				// Token: 0x04009696 RID: 38550
				Count
			}

			// Token: 0x02000C26 RID: 3110
			[OriginalName("Assembly-CSharp.dll", "", "ShaderAccuracy")]
			public enum ShaderAccuracy
			{
				// Token: 0x04009698 RID: 38552
				Fast,
				// Token: 0x04009699 RID: 38553
				High,
				// Token: 0x0400969A RID: 38554
				Count
			}
		}

		// Token: 0x02000822 RID: 2082
		public static class HD : Il2CppSystem.Object
		{
			// Token: 0x0600BE69 RID: 48745 RVA: 0x0005D282 File Offset: 0x0005B482
			// Note: this type is marked as 'beforefieldinit'.
			static HD()
			{
				Il2CppClassPointerStore<MaterialManager.HD>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, "HD");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialManager.HD>.NativeClassPtr);
			}

			// Token: 0x0600BE6A RID: 48746 RVA: 0x0005D2A2 File Offset: 0x0005B4A2
			public HD(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x02000C27 RID: 3111
			[OriginalName("Assembly-CSharp.dll", "", "Attenuation")]
			public enum Attenuation
			{
				// Token: 0x0400969C RID: 38556
				Linear,
				// Token: 0x0400969D RID: 38557
				Quadratic,
				// Token: 0x0400969E RID: 38558
				Count
			}

			// Token: 0x02000C28 RID: 3112
			[OriginalName("Assembly-CSharp.dll", "", "Shadow")]
			public enum Shadow
			{
				// Token: 0x040096A0 RID: 38560
				Off,
				// Token: 0x040096A1 RID: 38561
				On,
				// Token: 0x040096A2 RID: 38562
				Count
			}

			// Token: 0x02000C29 RID: 3113
			[OriginalName("Assembly-CSharp.dll", "", "Cookie")]
			public enum Cookie
			{
				// Token: 0x040096A4 RID: 38564
				Off,
				// Token: 0x040096A5 RID: 38565
				SingleChannel,
				// Token: 0x040096A6 RID: 38566
				RGBA,
				// Token: 0x040096A7 RID: 38567
				Count
			}
		}

		// Token: 0x02000823 RID: 2083
		public class IStaticProperties : Il2CppObjectBase
		{
			// Token: 0x0600BE6B RID: 48747 RVA: 0x002EB990 File Offset: 0x002E9B90
			// Note: this type is marked as 'beforefieldinit'.
			static IStaticProperties()
			{
				Il2CppClassPointerStore<MaterialManager.IStaticProperties>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, "IStaticProperties");
				MaterialManager.IStaticProperties.NativeMethodInfoPtr_GetPropertiesCount_Public_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.IStaticProperties>.NativeClassPtr, 100664559);
				MaterialManager.IStaticProperties.NativeMethodInfoPtr_GetMaterialID_Public_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.IStaticProperties>.NativeClassPtr, 100664560);
				MaterialManager.IStaticProperties.NativeMethodInfoPtr_ApplyToMaterial_Public_Abstract_Virtual_New_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.IStaticProperties>.NativeClassPtr, 100664561);
				MaterialManager.IStaticProperties.NativeMethodInfoPtr_GetShaderMode_Public_Abstract_Virtual_New_ShaderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.IStaticProperties>.NativeClassPtr, 100664562);
			}

			// Token: 0x0600BE6C RID: 48748 RVA: 0x002EBA04 File Offset: 0x002E9C04
			[CallerCount(0)]
			public unsafe virtual int GetPropertiesCount()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialManager.IStaticProperties.NativeMethodInfoPtr_GetPropertiesCount_Public_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BE6D RID: 48749 RVA: 0x002EBA4C File Offset: 0x002E9C4C
			[CallerCount(0)]
			public unsafe virtual int GetMaterialID()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialManager.IStaticProperties.NativeMethodInfoPtr_GetMaterialID_Public_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BE6E RID: 48750 RVA: 0x002EBA94 File Offset: 0x002E9C94
			[CallerCount(0)]
			public unsafe virtual void ApplyToMaterial(Material mat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialManager.IStaticProperties.NativeMethodInfoPtr_ApplyToMaterial_Public_Abstract_Virtual_New_Void_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BE6F RID: 48751 RVA: 0x002EBAE4 File Offset: 0x002E9CE4
			[CallerCount(0)]
			public unsafe virtual ShaderMode GetShaderMode()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialManager.IStaticProperties.NativeMethodInfoPtr_GetShaderMode_Public_Abstract_Virtual_New_ShaderMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BE70 RID: 48752 RVA: 0x0005D2AB File Offset: 0x0005B4AB
			public IStaticProperties(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040080E2 RID: 32994
			private static readonly IntPtr NativeMethodInfoPtr_GetPropertiesCount_Public_Abstract_Virtual_New_Int32_0;

			// Token: 0x040080E3 RID: 32995
			private static readonly IntPtr NativeMethodInfoPtr_GetMaterialID_Public_Abstract_Virtual_New_Int32_0;

			// Token: 0x040080E4 RID: 32996
			private static readonly IntPtr NativeMethodInfoPtr_ApplyToMaterial_Public_Abstract_Virtual_New_Void_Material_0;

			// Token: 0x040080E5 RID: 32997
			private static readonly IntPtr NativeMethodInfoPtr_GetShaderMode_Public_Abstract_Virtual_New_ShaderMode_0;
		}

		// Token: 0x02000824 RID: 2084
		[StructLayout(2)]
		public struct StaticPropertiesSD
		{
			// Token: 0x0600BE71 RID: 48753 RVA: 0x002EBB2C File Offset: 0x002E9D2C
			// Note: this type is marked as 'beforefieldinit'.
			static StaticPropertiesSD()
			{
				Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, "StaticPropertiesSD");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr);
				MaterialManager.StaticPropertiesSD.NativeFieldInfoPtr_blendingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, "blendingMode");
				MaterialManager.StaticPropertiesSD.NativeFieldInfoPtr_noise3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, "noise3D");
				MaterialManager.StaticPropertiesSD.NativeFieldInfoPtr_depthBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, "depthBlend");
				MaterialManager.StaticPropertiesSD.NativeFieldInfoPtr_colorGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, "colorGradient");
				MaterialManager.StaticPropertiesSD.NativeFieldInfoPtr_dynamicOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, "dynamicOcclusion");
				MaterialManager.StaticPropertiesSD.NativeFieldInfoPtr_meshSkewing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, "meshSkewing");
				MaterialManager.StaticPropertiesSD.NativeFieldInfoPtr_shaderAccuracy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, "shaderAccuracy");
				MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_GetShaderMode_Public_Virtual_Final_New_ShaderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, 100664563);
				MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_staticPropertiesCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, 100664564);
				MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_GetPropertiesCount_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, 100664565);
				MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_blendingModeID_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, 100664566);
				MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_noise3DID_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, 100664567);
				MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_depthBlendID_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, 100664568);
				MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_colorGradientID_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, 100664569);
				MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_dynamicOcclusionID_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, 100664570);
				MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_meshSkewingID_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, 100664571);
				MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_shaderAccuracyID_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, 100664572);
				MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_GetMaterialID_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, 100664573);
				MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_ApplyToMaterial_Public_Virtual_Final_New_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, 100664574);
			}

			// Token: 0x0600BE72 RID: 48754 RVA: 0x002EBCD4 File Offset: 0x002E9ED4
			[CallerCount(65)]
			[CachedScanResults(RefRangeStart = 31226, RefRangeEnd = 31291, XrefRangeStart = 31226, XrefRangeEnd = 31291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ShaderMode GetShaderMode()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_GetShaderMode_Public_Virtual_Final_New_ShaderMode_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003B37 RID: 15159
			// (get) Token: 0x0600BE73 RID: 48755 RVA: 0x002EBD04 File Offset: 0x002E9F04
			public unsafe static int staticPropertiesCount
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_staticPropertiesCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BE74 RID: 48756 RVA: 0x002EBD34 File Offset: 0x002E9F34
			[CallerCount(0)]
			public unsafe int GetPropertiesCount()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_GetPropertiesCount_Public_Virtual_Final_New_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003B38 RID: 15160
			// (get) Token: 0x0600BE75 RID: 48757 RVA: 0x002EBD64 File Offset: 0x002E9F64
			public unsafe int blendingModeID
			{
				[CallerCount(195)]
				[CachedScanResults(RefRangeStart = 34410, RefRangeEnd = 34605, XrefRangeStart = 34410, XrefRangeEnd = 34605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_blendingModeID_Private_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003B39 RID: 15161
			// (get) Token: 0x0600BE76 RID: 48758 RVA: 0x002EBD94 File Offset: 0x002E9F94
			public unsafe int noise3DID
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81583, XrefRangeEnd = 81584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_noise3DID_Private_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003B3A RID: 15162
			// (get) Token: 0x0600BE77 RID: 48759 RVA: 0x002EBDC4 File Offset: 0x002E9FC4
			public unsafe int depthBlendID
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81584, XrefRangeEnd = 81585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_depthBlendID_Private_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003B3B RID: 15163
			// (get) Token: 0x0600BE78 RID: 48760 RVA: 0x002EBDF4 File Offset: 0x002E9FF4
			public unsafe int colorGradientID
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81585, XrefRangeEnd = 81586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_colorGradientID_Private_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003B3C RID: 15164
			// (get) Token: 0x0600BE79 RID: 48761 RVA: 0x002EBE24 File Offset: 0x002EA024
			public unsafe int dynamicOcclusionID
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81586, XrefRangeEnd = 81587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_dynamicOcclusionID_Private_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003B3D RID: 15165
			// (get) Token: 0x0600BE7A RID: 48762 RVA: 0x002EBE54 File Offset: 0x002EA054
			public unsafe int meshSkewingID
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81587, XrefRangeEnd = 81588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_meshSkewingID_Private_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003B3E RID: 15166
			// (get) Token: 0x0600BE7B RID: 48763 RVA: 0x002EBE84 File Offset: 0x002EA084
			public unsafe int shaderAccuracyID
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81588, XrefRangeEnd = 81589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_shaderAccuracyID_Private_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BE7C RID: 48764 RVA: 0x002EBEB4 File Offset: 0x002EA0B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81589, XrefRangeEnd = 81600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int GetMaterialID()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_GetMaterialID_Public_Virtual_Final_New_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BE7D RID: 48765 RVA: 0x002EBEE4 File Offset: 0x002EA0E4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 81662, RefRangeEnd = 81663, XrefRangeStart = 81600, XrefRangeEnd = 81662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ApplyToMaterial(Material mat)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_ApplyToMaterial_Public_Virtual_Final_New_Void_Material_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BE7E RID: 48766 RVA: 0x0005D2B4 File Offset: 0x0005B4B4
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, ref this));
			}

			// Token: 0x040080E6 RID: 32998
			private static readonly IntPtr NativeFieldInfoPtr_blendingMode;

			// Token: 0x040080E7 RID: 32999
			private static readonly IntPtr NativeFieldInfoPtr_noise3D;

			// Token: 0x040080E8 RID: 33000
			private static readonly IntPtr NativeFieldInfoPtr_depthBlend;

			// Token: 0x040080E9 RID: 33001
			private static readonly IntPtr NativeFieldInfoPtr_colorGradient;

			// Token: 0x040080EA RID: 33002
			private static readonly IntPtr NativeFieldInfoPtr_dynamicOcclusion;

			// Token: 0x040080EB RID: 33003
			private static readonly IntPtr NativeFieldInfoPtr_meshSkewing;

			// Token: 0x040080EC RID: 33004
			private static readonly IntPtr NativeFieldInfoPtr_shaderAccuracy;

			// Token: 0x040080ED RID: 33005
			private static readonly IntPtr NativeMethodInfoPtr_GetShaderMode_Public_Virtual_Final_New_ShaderMode_0;

			// Token: 0x040080EE RID: 33006
			private static readonly IntPtr NativeMethodInfoPtr_get_staticPropertiesCount_Public_Static_get_Int32_0;

			// Token: 0x040080EF RID: 33007
			private static readonly IntPtr NativeMethodInfoPtr_GetPropertiesCount_Public_Virtual_Final_New_Int32_0;

			// Token: 0x040080F0 RID: 33008
			private static readonly IntPtr NativeMethodInfoPtr_get_blendingModeID_Private_get_Int32_0;

			// Token: 0x040080F1 RID: 33009
			private static readonly IntPtr NativeMethodInfoPtr_get_noise3DID_Private_get_Int32_0;

			// Token: 0x040080F2 RID: 33010
			private static readonly IntPtr NativeMethodInfoPtr_get_depthBlendID_Private_get_Int32_0;

			// Token: 0x040080F3 RID: 33011
			private static readonly IntPtr NativeMethodInfoPtr_get_colorGradientID_Private_get_Int32_0;

			// Token: 0x040080F4 RID: 33012
			private static readonly IntPtr NativeMethodInfoPtr_get_dynamicOcclusionID_Private_get_Int32_0;

			// Token: 0x040080F5 RID: 33013
			private static readonly IntPtr NativeMethodInfoPtr_get_meshSkewingID_Private_get_Int32_0;

			// Token: 0x040080F6 RID: 33014
			private static readonly IntPtr NativeMethodInfoPtr_get_shaderAccuracyID_Private_get_Int32_0;

			// Token: 0x040080F7 RID: 33015
			private static readonly IntPtr NativeMethodInfoPtr_GetMaterialID_Public_Virtual_Final_New_Int32_0;

			// Token: 0x040080F8 RID: 33016
			private static readonly IntPtr NativeMethodInfoPtr_ApplyToMaterial_Public_Virtual_Final_New_Void_Material_0;

			// Token: 0x040080F9 RID: 33017
			[FieldOffset(0)]
			public MaterialManager.BlendingMode blendingMode;

			// Token: 0x040080FA RID: 33018
			[FieldOffset(4)]
			public MaterialManager.Noise3D noise3D;

			// Token: 0x040080FB RID: 33019
			[FieldOffset(8)]
			public MaterialManager.SD.DepthBlend depthBlend;

			// Token: 0x040080FC RID: 33020
			[FieldOffset(12)]
			public MaterialManager.ColorGradient colorGradient;

			// Token: 0x040080FD RID: 33021
			[FieldOffset(16)]
			public MaterialManager.SD.DynamicOcclusion dynamicOcclusion;

			// Token: 0x040080FE RID: 33022
			[FieldOffset(20)]
			public MaterialManager.SD.MeshSkewing meshSkewing;

			// Token: 0x040080FF RID: 33023
			[FieldOffset(24)]
			public MaterialManager.SD.ShaderAccuracy shaderAccuracy;
		}

		// Token: 0x02000825 RID: 2085
		[StructLayout(2)]
		public struct StaticPropertiesHD
		{
			// Token: 0x0600BE7F RID: 48767 RVA: 0x002EBF1C File Offset: 0x002EA11C
			// Note: this type is marked as 'beforefieldinit'.
			static StaticPropertiesHD()
			{
				Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, "StaticPropertiesHD");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr);
				MaterialManager.StaticPropertiesHD.NativeFieldInfoPtr_blendingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, "blendingMode");
				MaterialManager.StaticPropertiesHD.NativeFieldInfoPtr_attenuation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, "attenuation");
				MaterialManager.StaticPropertiesHD.NativeFieldInfoPtr_noise3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, "noise3D");
				MaterialManager.StaticPropertiesHD.NativeFieldInfoPtr_colorGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, "colorGradient");
				MaterialManager.StaticPropertiesHD.NativeFieldInfoPtr_shadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, "shadow");
				MaterialManager.StaticPropertiesHD.NativeFieldInfoPtr_cookie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, "cookie");
				MaterialManager.StaticPropertiesHD.NativeFieldInfoPtr_raymarchingQualityIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, "raymarchingQualityIndex");
				MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_GetShaderMode_Public_Virtual_Final_New_ShaderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, 100664575);
				MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_staticPropertiesCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, 100664576);
				MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_GetPropertiesCount_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, 100664577);
				MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_blendingModeID_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, 100664578);
				MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_attenuationID_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, 100664579);
				MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_noise3DID_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, 100664580);
				MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_colorGradientID_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, 100664581);
				MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_dynamicOcclusionID_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, 100664582);
				MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_cookieID_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, 100664583);
				MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_raymarchingQualityID_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, 100664584);
				MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_GetMaterialID_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, 100664585);
				MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_ApplyToMaterial_Public_Virtual_Final_New_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, 100664586);
			}

			// Token: 0x0600BE80 RID: 48768 RVA: 0x002EC0C4 File Offset: 0x002EA2C4
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 76499, RefRangeEnd = 76503, XrefRangeStart = 76499, XrefRangeEnd = 76503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ShaderMode GetShaderMode()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_GetShaderMode_Public_Virtual_Final_New_ShaderMode_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003B3F RID: 15167
			// (get) Token: 0x0600BE81 RID: 48769 RVA: 0x002EC0F4 File Offset: 0x002EA2F4
			public unsafe static int staticPropertiesCount
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81663, XrefRangeEnd = 81665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_staticPropertiesCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BE82 RID: 48770 RVA: 0x002EC124 File Offset: 0x002EA324
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int GetPropertiesCount()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_GetPropertiesCount_Public_Virtual_Final_New_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003B40 RID: 15168
			// (get) Token: 0x0600BE83 RID: 48771 RVA: 0x002EC154 File Offset: 0x002EA354
			public unsafe int blendingModeID
			{
				[CallerCount(195)]
				[CachedScanResults(RefRangeStart = 34410, RefRangeEnd = 34605, XrefRangeStart = 34410, XrefRangeEnd = 34605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_blendingModeID_Private_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003B41 RID: 15169
			// (get) Token: 0x0600BE84 RID: 48772 RVA: 0x002EC184 File Offset: 0x002EA384
			public unsafe int attenuationID
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_attenuationID_Private_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003B42 RID: 15170
			// (get) Token: 0x0600BE85 RID: 48773 RVA: 0x002EC1B4 File Offset: 0x002EA3B4
			public unsafe int noise3DID
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81665, XrefRangeEnd = 81666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_noise3DID_Private_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003B43 RID: 15171
			// (get) Token: 0x0600BE86 RID: 48774 RVA: 0x002EC1E4 File Offset: 0x002EA3E4
			public unsafe int colorGradientID
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_colorGradientID_Private_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003B44 RID: 15172
			// (get) Token: 0x0600BE87 RID: 48775 RVA: 0x002EC214 File Offset: 0x002EA414
			public unsafe int dynamicOcclusionID
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81666, XrefRangeEnd = 81667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_dynamicOcclusionID_Private_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003B45 RID: 15173
			// (get) Token: 0x0600BE88 RID: 48776 RVA: 0x002EC244 File Offset: 0x002EA444
			public unsafe int cookieID
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81667, XrefRangeEnd = 81668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_cookieID_Private_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003B46 RID: 15174
			// (get) Token: 0x0600BE89 RID: 48777 RVA: 0x002EC274 File Offset: 0x002EA474
			public unsafe int raymarchingQualityID
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_raymarchingQualityID_Private_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BE8A RID: 48778 RVA: 0x002EC2A4 File Offset: 0x002EA4A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81668, XrefRangeEnd = 81677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int GetMaterialID()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_GetMaterialID_Public_Virtual_Final_New_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BE8B RID: 48779 RVA: 0x002EC2D4 File Offset: 0x002EA4D4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 81752, RefRangeEnd = 81753, XrefRangeStart = 81677, XrefRangeEnd = 81752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ApplyToMaterial(Material mat)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_ApplyToMaterial_Public_Virtual_Final_New_Void_Material_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BE8C RID: 48780 RVA: 0x0005D2C6 File Offset: 0x0005B4C6
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, ref this));
			}

			// Token: 0x04008100 RID: 33024
			private static readonly IntPtr NativeFieldInfoPtr_blendingMode;

			// Token: 0x04008101 RID: 33025
			private static readonly IntPtr NativeFieldInfoPtr_attenuation;

			// Token: 0x04008102 RID: 33026
			private static readonly IntPtr NativeFieldInfoPtr_noise3D;

			// Token: 0x04008103 RID: 33027
			private static readonly IntPtr NativeFieldInfoPtr_colorGradient;

			// Token: 0x04008104 RID: 33028
			private static readonly IntPtr NativeFieldInfoPtr_shadow;

			// Token: 0x04008105 RID: 33029
			private static readonly IntPtr NativeFieldInfoPtr_cookie;

			// Token: 0x04008106 RID: 33030
			private static readonly IntPtr NativeFieldInfoPtr_raymarchingQualityIndex;

			// Token: 0x04008107 RID: 33031
			private static readonly IntPtr NativeMethodInfoPtr_GetShaderMode_Public_Virtual_Final_New_ShaderMode_0;

			// Token: 0x04008108 RID: 33032
			private static readonly IntPtr NativeMethodInfoPtr_get_staticPropertiesCount_Public_Static_get_Int32_0;

			// Token: 0x04008109 RID: 33033
			private static readonly IntPtr NativeMethodInfoPtr_GetPropertiesCount_Public_Virtual_Final_New_Int32_0;

			// Token: 0x0400810A RID: 33034
			private static readonly IntPtr NativeMethodInfoPtr_get_blendingModeID_Private_get_Int32_0;

			// Token: 0x0400810B RID: 33035
			private static readonly IntPtr NativeMethodInfoPtr_get_attenuationID_Private_get_Int32_0;

			// Token: 0x0400810C RID: 33036
			private static readonly IntPtr NativeMethodInfoPtr_get_noise3DID_Private_get_Int32_0;

			// Token: 0x0400810D RID: 33037
			private static readonly IntPtr NativeMethodInfoPtr_get_colorGradientID_Private_get_Int32_0;

			// Token: 0x0400810E RID: 33038
			private static readonly IntPtr NativeMethodInfoPtr_get_dynamicOcclusionID_Private_get_Int32_0;

			// Token: 0x0400810F RID: 33039
			private static readonly IntPtr NativeMethodInfoPtr_get_cookieID_Private_get_Int32_0;

			// Token: 0x04008110 RID: 33040
			private static readonly IntPtr NativeMethodInfoPtr_get_raymarchingQualityID_Private_get_Int32_0;

			// Token: 0x04008111 RID: 33041
			private static readonly IntPtr NativeMethodInfoPtr_GetMaterialID_Public_Virtual_Final_New_Int32_0;

			// Token: 0x04008112 RID: 33042
			private static readonly IntPtr NativeMethodInfoPtr_ApplyToMaterial_Public_Virtual_Final_New_Void_Material_0;

			// Token: 0x04008113 RID: 33043
			[FieldOffset(0)]
			public MaterialManager.BlendingMode blendingMode;

			// Token: 0x04008114 RID: 33044
			[FieldOffset(4)]
			public MaterialManager.HD.Attenuation attenuation;

			// Token: 0x04008115 RID: 33045
			[FieldOffset(8)]
			public MaterialManager.Noise3D noise3D;

			// Token: 0x04008116 RID: 33046
			[FieldOffset(12)]
			public MaterialManager.ColorGradient colorGradient;

			// Token: 0x04008117 RID: 33047
			[FieldOffset(16)]
			public MaterialManager.HD.Shadow shadow;

			// Token: 0x04008118 RID: 33048
			[FieldOffset(20)]
			public MaterialManager.HD.Cookie cookie;

			// Token: 0x04008119 RID: 33049
			[FieldOffset(24)]
			public int raymarchingQualityIndex;
		}

		// Token: 0x02000826 RID: 2086
		public class MaterialsGroup : Il2CppSystem.Object
		{
			// Token: 0x0600BE8D RID: 48781 RVA: 0x002EC30C File Offset: 0x002EA50C
			// Note: this type is marked as 'beforefieldinit'.
			static MaterialsGroup()
			{
				Il2CppClassPointerStore<MaterialManager.MaterialsGroup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, "MaterialsGroup");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialManager.MaterialsGroup>.NativeClassPtr);
				MaterialManager.MaterialsGroup.NativeFieldInfoPtr_materials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.MaterialsGroup>.NativeClassPtr, "materials");
				MaterialManager.MaterialsGroup.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.MaterialsGroup>.NativeClassPtr, 100664587);
			}

			// Token: 0x0600BE8E RID: 48782 RVA: 0x002EC360 File Offset: 0x002EA560
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81753, XrefRangeEnd = 81758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MaterialsGroup(int count) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialManager.MaterialsGroup>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.MaterialsGroup.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BE8F RID: 48783 RVA: 0x0005D2D8 File Offset: 0x0005B4D8
			public MaterialsGroup(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003B47 RID: 15175
			// (get) Token: 0x0600BE90 RID: 48784 RVA: 0x002EC3A8 File Offset: 0x002EA5A8
			// (set) Token: 0x0600BE91 RID: 48785 RVA: 0x0005D2E1 File Offset: 0x0005B4E1
			public unsafe Il2CppReferenceArray<Material> materials
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialManager.MaterialsGroup.NativeFieldInfoPtr_materials);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialManager.MaterialsGroup.NativeFieldInfoPtr_materials), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400811A RID: 33050
			private static readonly IntPtr NativeFieldInfoPtr_materials;

			// Token: 0x0400811B RID: 33051
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
		}

		// Token: 0x02000827 RID: 2087
		[OriginalName("Assembly-CSharp.dll", "", "ZWrite")]
		public enum ZWrite
		{
			// Token: 0x0400811D RID: 33053
			Off,
			// Token: 0x0400811E RID: 33054
			On
		}
	}
}
