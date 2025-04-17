using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace Il2CppLiquidVolumeFX
{
	// Token: 0x020000DA RID: 218
	public class LiquidVolumeDepthPrePassRenderFeature : ScriptableRendererFeature
	{
		// Token: 0x060011AB RID: 4523 RVA: 0x000A7F98 File Offset: 0x000A6198
		// Note: this type is marked as 'beforefieldinit'.
		static LiquidVolumeDepthPrePassRenderFeature()
		{
			Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "LiquidVolumeFX", "LiquidVolumeDepthPrePassRenderFeature");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr);
			LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_lvBackRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, "lvBackRenderers");
			LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_lvFrontRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, "lvFrontRenderers");
			LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_shader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, "shader");
			LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_installed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, "installed");
			LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, "mat");
			LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_backPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, "backPass");
			LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_frontPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, "frontPass");
			LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_interleavedRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, "interleavedRendering");
			LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_renderPassEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, "renderPassEvent");
			LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr_AddLiquidToBackRenderers_Public_Static_Void_LiquidVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, 100665317);
			LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr_RemoveLiquidFromBackRenderers_Public_Static_Void_LiquidVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, 100665318);
			LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr_AddLiquidToFrontRenderers_Public_Static_Void_LiquidVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, 100665319);
			LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr_RemoveLiquidFromFrontRenderers_Public_Static_Void_LiquidVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, 100665320);
			LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, 100665321);
			LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr_Create_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, 100665322);
			LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr_AddRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, 100665323);
			LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, 100665324);
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x000A811C File Offset: 0x000A631C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88322, RefRangeEnd = 88323, XrefRangeStart = 88305, XrefRangeEnd = 88322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddLiquidToBackRenderers(LiquidVolume lv)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(lv);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr_AddLiquidToBackRenderers_Public_Static_Void_LiquidVolume_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011AD RID: 4525 RVA: 0x000A8154 File Offset: 0x000A6354
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 88340, RefRangeEnd = 88342, XrefRangeStart = 88323, XrefRangeEnd = 88340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveLiquidFromBackRenderers(LiquidVolume lv)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(lv);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr_RemoveLiquidFromBackRenderers_Public_Static_Void_LiquidVolume_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x000A818C File Offset: 0x000A638C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88359, RefRangeEnd = 88360, XrefRangeStart = 88342, XrefRangeEnd = 88359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddLiquidToFrontRenderers(LiquidVolume lv)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(lv);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr_AddLiquidToFrontRenderers_Public_Static_Void_LiquidVolume_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x000A81C4 File Offset: 0x000A63C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 88377, RefRangeEnd = 88379, XrefRangeStart = 88360, XrefRangeEnd = 88377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveLiquidFromFrontRenderers(LiquidVolume lv)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(lv);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr_RemoveLiquidFromFrontRenderers_Public_Static_Void_LiquidVolume_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x000A81FC File Offset: 0x000A63FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88379, XrefRangeEnd = 88396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x000A8230 File Offset: 0x000A6430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88396, XrefRangeEnd = 88421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Create()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr_Create_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x000A826C File Offset: 0x000A646C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88421, XrefRangeEnd = 88437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr_AddRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011B3 RID: 4531 RVA: 0x000A82CC File Offset: 0x000A64CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88437, XrefRangeEnd = 88438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LiquidVolumeDepthPrePassRenderFeature() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x0000AC64 File Offset: 0x00008E64
		public LiquidVolumeDepthPrePassRenderFeature(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x060011B5 RID: 4533 RVA: 0x000A8308 File Offset: 0x000A6508
		// (set) Token: 0x060011B6 RID: 4534 RVA: 0x0000AC6D File Offset: 0x00008E6D
		public unsafe static List<LiquidVolume> lvBackRenderers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_lvBackRenderers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LiquidVolume>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_lvBackRenderers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x060011B7 RID: 4535 RVA: 0x000A8330 File Offset: 0x000A6530
		// (set) Token: 0x060011B8 RID: 4536 RVA: 0x0000AC7F File Offset: 0x00008E7F
		public unsafe static List<LiquidVolume> lvFrontRenderers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_lvFrontRenderers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LiquidVolume>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_lvFrontRenderers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x060011B9 RID: 4537 RVA: 0x000A8358 File Offset: 0x000A6558
		// (set) Token: 0x060011BA RID: 4538 RVA: 0x0000AC91 File Offset: 0x00008E91
		public unsafe Shader shader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_shader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_shader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x060011BB RID: 4539 RVA: 0x000A8388 File Offset: 0x000A6588
		// (set) Token: 0x060011BC RID: 4540 RVA: 0x0000ACB0 File Offset: 0x00008EB0
		public unsafe static bool installed
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_installed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_installed, (void*)(&value));
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x060011BD RID: 4541 RVA: 0x000A83A4 File Offset: 0x000A65A4
		// (set) Token: 0x060011BE RID: 4542 RVA: 0x0000ACBE File Offset: 0x00008EBE
		public unsafe Material mat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_mat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_mat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x060011BF RID: 4543 RVA: 0x000A83D4 File Offset: 0x000A65D4
		// (set) Token: 0x060011C0 RID: 4544 RVA: 0x0000ACDD File Offset: 0x00008EDD
		public unsafe LiquidVolumeDepthPrePassRenderFeature.DepthPass backPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_backPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidVolumeDepthPrePassRenderFeature.DepthPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_backPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x060011C1 RID: 4545 RVA: 0x000A8404 File Offset: 0x000A6604
		// (set) Token: 0x060011C2 RID: 4546 RVA: 0x0000ACFC File Offset: 0x00008EFC
		public unsafe LiquidVolumeDepthPrePassRenderFeature.DepthPass frontPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_frontPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidVolumeDepthPrePassRenderFeature.DepthPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_frontPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x060011C3 RID: 4547 RVA: 0x000A8434 File Offset: 0x000A6634
		// (set) Token: 0x060011C4 RID: 4548 RVA: 0x0000AD1B File Offset: 0x00008F1B
		public unsafe bool interleavedRendering
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_interleavedRendering);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_interleavedRendering)) = value;
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x060011C5 RID: 4549 RVA: 0x000A845C File Offset: 0x000A665C
		// (set) Token: 0x060011C6 RID: 4550 RVA: 0x0000AD36 File Offset: 0x00008F36
		public unsafe RenderPassEvent renderPassEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_renderPassEvent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_renderPassEvent)) = value;
			}
		}

		// Token: 0x04000BC7 RID: 3015
		private static readonly IntPtr NativeFieldInfoPtr_lvBackRenderers;

		// Token: 0x04000BC8 RID: 3016
		private static readonly IntPtr NativeFieldInfoPtr_lvFrontRenderers;

		// Token: 0x04000BC9 RID: 3017
		private static readonly IntPtr NativeFieldInfoPtr_shader;

		// Token: 0x04000BCA RID: 3018
		private static readonly IntPtr NativeFieldInfoPtr_installed;

		// Token: 0x04000BCB RID: 3019
		private static readonly IntPtr NativeFieldInfoPtr_mat;

		// Token: 0x04000BCC RID: 3020
		private static readonly IntPtr NativeFieldInfoPtr_backPass;

		// Token: 0x04000BCD RID: 3021
		private static readonly IntPtr NativeFieldInfoPtr_frontPass;

		// Token: 0x04000BCE RID: 3022
		private static readonly IntPtr NativeFieldInfoPtr_interleavedRendering;

		// Token: 0x04000BCF RID: 3023
		private static readonly IntPtr NativeFieldInfoPtr_renderPassEvent;

		// Token: 0x04000BD0 RID: 3024
		private static readonly IntPtr NativeMethodInfoPtr_AddLiquidToBackRenderers_Public_Static_Void_LiquidVolume_0;

		// Token: 0x04000BD1 RID: 3025
		private static readonly IntPtr NativeMethodInfoPtr_RemoveLiquidFromBackRenderers_Public_Static_Void_LiquidVolume_0;

		// Token: 0x04000BD2 RID: 3026
		private static readonly IntPtr NativeMethodInfoPtr_AddLiquidToFrontRenderers_Public_Static_Void_LiquidVolume_0;

		// Token: 0x04000BD3 RID: 3027
		private static readonly IntPtr NativeMethodInfoPtr_RemoveLiquidFromFrontRenderers_Public_Static_Void_LiquidVolume_0;

		// Token: 0x04000BD4 RID: 3028
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000BD5 RID: 3029
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Virtual_Void_0;

		// Token: 0x04000BD6 RID: 3030
		private static readonly IntPtr NativeMethodInfoPtr_AddRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0;

		// Token: 0x04000BD7 RID: 3031
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200084A RID: 2122
		public static class ShaderParams : Il2CppSystem.Object
		{
			// Token: 0x0600C017 RID: 49175 RVA: 0x002EFCD8 File Offset: 0x002EDED8
			// Note: this type is marked as 'beforefieldinit'.
			static ShaderParams()
			{
				Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.ShaderParams>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, "ShaderParams");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.ShaderParams>.NativeClassPtr);
				LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_RTBackBufferName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.ShaderParams>.NativeClassPtr, "RTBackBufferName");
				LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_RTBackBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.ShaderParams>.NativeClassPtr, "RTBackBuffer");
				LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_RTFrontBufferName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.ShaderParams>.NativeClassPtr, "RTFrontBufferName");
				LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_RTFrontBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.ShaderParams>.NativeClassPtr, "RTFrontBuffer");
				LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_FlaskThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.ShaderParams>.NativeClassPtr, "FlaskThickness");
				LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_ForcedInvisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.ShaderParams>.NativeClassPtr, "ForcedInvisible");
				LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_SKW_FP_RENDER_TEXTURE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.ShaderParams>.NativeClassPtr, "SKW_FP_RENDER_TEXTURE");
			}

			// Token: 0x0600C018 RID: 49176 RVA: 0x0005DD69 File Offset: 0x0005BF69
			public ShaderParams(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003BD2 RID: 15314
			// (get) Token: 0x0600C019 RID: 49177 RVA: 0x002EFD90 File Offset: 0x002EDF90
			// (set) Token: 0x0600C01A RID: 49178 RVA: 0x0005DD72 File Offset: 0x0005BF72
			public unsafe static string RTBackBufferName
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_RTBackBufferName, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_RTBackBufferName, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003BD3 RID: 15315
			// (get) Token: 0x0600C01B RID: 49179 RVA: 0x002EFDB0 File Offset: 0x002EDFB0
			// (set) Token: 0x0600C01C RID: 49180 RVA: 0x0005DD84 File Offset: 0x0005BF84
			public unsafe static int RTBackBuffer
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_RTBackBuffer, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_RTBackBuffer, (void*)(&value));
				}
			}

			// Token: 0x17003BD4 RID: 15316
			// (get) Token: 0x0600C01D RID: 49181 RVA: 0x002EFDCC File Offset: 0x002EDFCC
			// (set) Token: 0x0600C01E RID: 49182 RVA: 0x0005DD92 File Offset: 0x0005BF92
			public unsafe static string RTFrontBufferName
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_RTFrontBufferName, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_RTFrontBufferName, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003BD5 RID: 15317
			// (get) Token: 0x0600C01F RID: 49183 RVA: 0x002EFDEC File Offset: 0x002EDFEC
			// (set) Token: 0x0600C020 RID: 49184 RVA: 0x0005DDA4 File Offset: 0x0005BFA4
			public unsafe static int RTFrontBuffer
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_RTFrontBuffer, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_RTFrontBuffer, (void*)(&value));
				}
			}

			// Token: 0x17003BD6 RID: 15318
			// (get) Token: 0x0600C021 RID: 49185 RVA: 0x002EFE08 File Offset: 0x002EE008
			// (set) Token: 0x0600C022 RID: 49186 RVA: 0x0005DDB2 File Offset: 0x0005BFB2
			public unsafe static int FlaskThickness
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_FlaskThickness, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_FlaskThickness, (void*)(&value));
				}
			}

			// Token: 0x17003BD7 RID: 15319
			// (get) Token: 0x0600C023 RID: 49187 RVA: 0x002EFE24 File Offset: 0x002EE024
			// (set) Token: 0x0600C024 RID: 49188 RVA: 0x0005DDC0 File Offset: 0x0005BFC0
			public unsafe static int ForcedInvisible
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_ForcedInvisible, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_ForcedInvisible, (void*)(&value));
				}
			}

			// Token: 0x17003BD8 RID: 15320
			// (get) Token: 0x0600C025 RID: 49189 RVA: 0x002EFE40 File Offset: 0x002EE040
			// (set) Token: 0x0600C026 RID: 49190 RVA: 0x0005DDCE File Offset: 0x0005BFCE
			public unsafe static string SKW_FP_RENDER_TEXTURE
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_SKW_FP_RENDER_TEXTURE, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_SKW_FP_RENDER_TEXTURE, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008212 RID: 33298
			private static readonly IntPtr NativeFieldInfoPtr_RTBackBufferName;

			// Token: 0x04008213 RID: 33299
			private static readonly IntPtr NativeFieldInfoPtr_RTBackBuffer;

			// Token: 0x04008214 RID: 33300
			private static readonly IntPtr NativeFieldInfoPtr_RTFrontBufferName;

			// Token: 0x04008215 RID: 33301
			private static readonly IntPtr NativeFieldInfoPtr_RTFrontBuffer;

			// Token: 0x04008216 RID: 33302
			private static readonly IntPtr NativeFieldInfoPtr_FlaskThickness;

			// Token: 0x04008217 RID: 33303
			private static readonly IntPtr NativeFieldInfoPtr_ForcedInvisible;

			// Token: 0x04008218 RID: 33304
			private static readonly IntPtr NativeFieldInfoPtr_SKW_FP_RENDER_TEXTURE;
		}

		// Token: 0x0200084B RID: 2123
		[OriginalName("Assembly-CSharp.dll", "", "Pass")]
		public enum Pass
		{
			// Token: 0x0400821A RID: 33306
			BackBuffer,
			// Token: 0x0400821B RID: 33307
			FrontBuffer
		}

		// Token: 0x0200084C RID: 2124
		public class DepthPass : ScriptableRenderPass
		{
			// Token: 0x0600C027 RID: 49191 RVA: 0x002EFE60 File Offset: 0x002EE060
			// Note: this type is marked as 'beforefieldinit'.
			static DepthPass()
			{
				Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, "DepthPass");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr);
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_profilerTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, "profilerTag");
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, "mat");
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_targetNameId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, "targetNameId");
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_targetRT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, "targetRT");
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_passId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, "passId");
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_lvRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, "lvRenderers");
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, "renderer");
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_interleavedRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, "interleavedRendering");
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_currentCameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, "currentCameraPosition");
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_passData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, "passData");
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeMethodInfoPtr__ctor_Public_Void_Material_Pass_RenderPassEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, 100665327);
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeMethodInfoPtr_Setup_Public_Void_LiquidVolumeDepthPrePassRenderFeature_ScriptableRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, 100665328);
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeMethodInfoPtr_SortByDistanceToCamera_Private_Int32_LiquidVolume_LiquidVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, 100665329);
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeMethodInfoPtr_Configure_Public_Virtual_Void_CommandBuffer_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, 100665330);
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, 100665331);
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeMethodInfoPtr_ExecutePass_Private_Static_Void_PassData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, 100665332);
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeMethodInfoPtr_CleanUp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, 100665333);
			}

			// Token: 0x0600C028 RID: 49192 RVA: 0x002EFFE0 File Offset: 0x002EE1E0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 88199, RefRangeEnd = 88201, XrefRangeStart = 88170, XrefRangeEnd = 88199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DepthPass(Material mat, LiquidVolumeDepthPrePassRenderFeature.Pass pass, RenderPassEvent renderPassEvent) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pass;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderPassEvent;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeMethodInfoPtr__ctor_Public_Void_Material_Pass_RenderPassEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C029 RID: 49193 RVA: 0x002F0048 File Offset: 0x002EE248
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88201, XrefRangeEnd = 88202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Setup(LiquidVolumeDepthPrePassRenderFeature feature, ScriptableRenderer renderer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(feature);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(renderer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeMethodInfoPtr_Setup_Public_Void_LiquidVolumeDepthPrePassRenderFeature_ScriptableRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C02A RID: 49194 RVA: 0x002F009C File Offset: 0x002EE29C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88202, XrefRangeEnd = 88224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int SortByDistanceToCamera(LiquidVolume lv1, LiquidVolume lv2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lv1);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lv2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeMethodInfoPtr_SortByDistanceToCamera_Private_Int32_LiquidVolume_LiquidVolume_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C02B RID: 49195 RVA: 0x002F00FC File Offset: 0x002EE2FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88224, XrefRangeEnd = 88233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cameraTextureDescriptor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeMethodInfoPtr_Configure_Public_Virtual_Void_CommandBuffer_RenderTextureDescriptor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C02C RID: 49196 RVA: 0x002F0158 File Offset: 0x002EE358
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88233, XrefRangeEnd = 88253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref context;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C02D RID: 49197 RVA: 0x002F01B4 File Offset: 0x002EE3B4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 88300, RefRangeEnd = 88301, XrefRangeStart = 88253, XrefRangeEnd = 88300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void ExecutePass(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData passData)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(passData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeMethodInfoPtr_ExecutePass_Private_Static_Void_PassData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C02E RID: 49198 RVA: 0x002F01EC File Offset: 0x002EE3EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88301, XrefRangeEnd = 88305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CleanUp()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeMethodInfoPtr_CleanUp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C02F RID: 49199 RVA: 0x0005DDE0 File Offset: 0x0005BFE0
			public DepthPass(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003BD9 RID: 15321
			// (get) Token: 0x0600C030 RID: 49200 RVA: 0x002F0220 File Offset: 0x002EE420
			// (set) Token: 0x0600C031 RID: 49201 RVA: 0x0005DDE9 File Offset: 0x0005BFE9
			public unsafe static string profilerTag
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_profilerTag, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_profilerTag, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003BDA RID: 15322
			// (get) Token: 0x0600C032 RID: 49202 RVA: 0x002F0240 File Offset: 0x002EE440
			// (set) Token: 0x0600C033 RID: 49203 RVA: 0x0005DDFB File Offset: 0x0005BFFB
			public unsafe Material mat
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_mat);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_mat), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BDB RID: 15323
			// (get) Token: 0x0600C034 RID: 49204 RVA: 0x002F0270 File Offset: 0x002EE470
			// (set) Token: 0x0600C035 RID: 49205 RVA: 0x0005DE1A File Offset: 0x0005C01A
			public unsafe int targetNameId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_targetNameId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_targetNameId)) = value;
				}
			}

			// Token: 0x17003BDC RID: 15324
			// (get) Token: 0x0600C036 RID: 49206 RVA: 0x002F0298 File Offset: 0x002EE498
			// (set) Token: 0x0600C037 RID: 49207 RVA: 0x0005DE35 File Offset: 0x0005C035
			public unsafe RTHandle targetRT
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_targetRT);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_targetRT), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BDD RID: 15325
			// (get) Token: 0x0600C038 RID: 49208 RVA: 0x002F02C8 File Offset: 0x002EE4C8
			// (set) Token: 0x0600C039 RID: 49209 RVA: 0x0005DE54 File Offset: 0x0005C054
			public unsafe int passId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_passId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_passId)) = value;
				}
			}

			// Token: 0x17003BDE RID: 15326
			// (get) Token: 0x0600C03A RID: 49210 RVA: 0x002F02F0 File Offset: 0x002EE4F0
			// (set) Token: 0x0600C03B RID: 49211 RVA: 0x0005DE6F File Offset: 0x0005C06F
			public unsafe List<LiquidVolume> lvRenderers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_lvRenderers);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LiquidVolume>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_lvRenderers), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BDF RID: 15327
			// (get) Token: 0x0600C03C RID: 49212 RVA: 0x002F0320 File Offset: 0x002EE520
			// (set) Token: 0x0600C03D RID: 49213 RVA: 0x0005DE8E File Offset: 0x0005C08E
			public unsafe ScriptableRenderer renderer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_renderer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_renderer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BE0 RID: 15328
			// (get) Token: 0x0600C03E RID: 49214 RVA: 0x002F0350 File Offset: 0x002EE550
			// (set) Token: 0x0600C03F RID: 49215 RVA: 0x0005DEAD File Offset: 0x0005C0AD
			public unsafe bool interleavedRendering
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_interleavedRendering);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_interleavedRendering)) = value;
				}
			}

			// Token: 0x17003BE1 RID: 15329
			// (get) Token: 0x0600C040 RID: 49216 RVA: 0x002F0378 File Offset: 0x002EE578
			// (set) Token: 0x0600C041 RID: 49217 RVA: 0x0005DEC8 File Offset: 0x0005C0C8
			public unsafe static Vector3 currentCameraPosition
			{
				get
				{
					Vector3 result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_currentCameraPosition, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_currentCameraPosition, (void*)(&value));
				}
			}

			// Token: 0x17003BE2 RID: 15330
			// (get) Token: 0x0600C042 RID: 49218 RVA: 0x002F0394 File Offset: 0x002EE594
			// (set) Token: 0x0600C043 RID: 49219 RVA: 0x0005DED6 File Offset: 0x0005C0D6
			public unsafe LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData passData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_passData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_passData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400821C RID: 33308
			private static readonly IntPtr NativeFieldInfoPtr_profilerTag;

			// Token: 0x0400821D RID: 33309
			private static readonly IntPtr NativeFieldInfoPtr_mat;

			// Token: 0x0400821E RID: 33310
			private static readonly IntPtr NativeFieldInfoPtr_targetNameId;

			// Token: 0x0400821F RID: 33311
			private static readonly IntPtr NativeFieldInfoPtr_targetRT;

			// Token: 0x04008220 RID: 33312
			private static readonly IntPtr NativeFieldInfoPtr_passId;

			// Token: 0x04008221 RID: 33313
			private static readonly IntPtr NativeFieldInfoPtr_lvRenderers;

			// Token: 0x04008222 RID: 33314
			private static readonly IntPtr NativeFieldInfoPtr_renderer;

			// Token: 0x04008223 RID: 33315
			private static readonly IntPtr NativeFieldInfoPtr_interleavedRendering;

			// Token: 0x04008224 RID: 33316
			private static readonly IntPtr NativeFieldInfoPtr_currentCameraPosition;

			// Token: 0x04008225 RID: 33317
			private static readonly IntPtr NativeFieldInfoPtr_passData;

			// Token: 0x04008226 RID: 33318
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Material_Pass_RenderPassEvent_0;

			// Token: 0x04008227 RID: 33319
			private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_LiquidVolumeDepthPrePassRenderFeature_ScriptableRenderer_0;

			// Token: 0x04008228 RID: 33320
			private static readonly IntPtr NativeMethodInfoPtr_SortByDistanceToCamera_Private_Int32_LiquidVolume_LiquidVolume_0;

			// Token: 0x04008229 RID: 33321
			private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Virtual_Void_CommandBuffer_RenderTextureDescriptor_0;

			// Token: 0x0400822A RID: 33322
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

			// Token: 0x0400822B RID: 33323
			private static readonly IntPtr NativeMethodInfoPtr_ExecutePass_Private_Static_Void_PassData_0;

			// Token: 0x0400822C RID: 33324
			private static readonly IntPtr NativeMethodInfoPtr_CleanUp_Public_Void_0;

			// Token: 0x02000C2A RID: 3114
			public class PassData : Il2CppSystem.Object
			{
				// Token: 0x0600E0F5 RID: 57589 RVA: 0x0034E510 File Offset: 0x0034C710
				// Note: this type is marked as 'beforefieldinit'.
				static PassData()
				{
					Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, "PassData");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData>.NativeClassPtr);
					LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_cam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData>.NativeClassPtr, "cam");
					LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_cmd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData>.NativeClassPtr, "cmd");
					LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_depthPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData>.NativeClassPtr, "depthPass");
					LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData>.NativeClassPtr, "mat");
					LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData>.NativeClassPtr, "source");
					LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData>.NativeClassPtr, "depth");
					LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_cameraTargetDescriptor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData>.NativeClassPtr, "cameraTargetDescriptor");
					LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData>.NativeClassPtr, 100665334);
				}

				// Token: 0x0600E0F6 RID: 57590 RVA: 0x0034E5DC File Offset: 0x0034C7DC
				[CallerCount(2259)]
				[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe PassData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E0F7 RID: 57591 RVA: 0x0006DABD File Offset: 0x0006BCBD
				public PassData(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170045B1 RID: 17841
				// (get) Token: 0x0600E0F8 RID: 57592 RVA: 0x0034E618 File Offset: 0x0034C818
				// (set) Token: 0x0600E0F9 RID: 57593 RVA: 0x0006DAC6 File Offset: 0x0006BCC6
				public unsafe Camera cam
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_cam);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_cam), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170045B2 RID: 17842
				// (get) Token: 0x0600E0FA RID: 57594 RVA: 0x0034E648 File Offset: 0x0034C848
				// (set) Token: 0x0600E0FB RID: 57595 RVA: 0x0006DAE5 File Offset: 0x0006BCE5
				public unsafe CommandBuffer cmd
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_cmd);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<CommandBuffer>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_cmd), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170045B3 RID: 17843
				// (get) Token: 0x0600E0FC RID: 57596 RVA: 0x0034E678 File Offset: 0x0034C878
				// (set) Token: 0x0600E0FD RID: 57597 RVA: 0x0006DB04 File Offset: 0x0006BD04
				public unsafe LiquidVolumeDepthPrePassRenderFeature.DepthPass depthPass
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_depthPass);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidVolumeDepthPrePassRenderFeature.DepthPass>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_depthPass), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170045B4 RID: 17844
				// (get) Token: 0x0600E0FE RID: 57598 RVA: 0x0034E6A8 File Offset: 0x0034C8A8
				// (set) Token: 0x0600E0FF RID: 57599 RVA: 0x0006DB23 File Offset: 0x0006BD23
				public unsafe Material mat
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_mat);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_mat), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170045B5 RID: 17845
				// (get) Token: 0x0600E100 RID: 57600 RVA: 0x0034E6D8 File Offset: 0x0034C8D8
				// (set) Token: 0x0600E101 RID: 57601 RVA: 0x0006DB42 File Offset: 0x0006BD42
				public unsafe RTHandle source
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_source);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170045B6 RID: 17846
				// (get) Token: 0x0600E102 RID: 57602 RVA: 0x0034E708 File Offset: 0x0034C908
				// (set) Token: 0x0600E103 RID: 57603 RVA: 0x0006DB61 File Offset: 0x0006BD61
				public unsafe RTHandle depth
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_depth);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_depth), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170045B7 RID: 17847
				// (get) Token: 0x0600E104 RID: 57604 RVA: 0x0034E738 File Offset: 0x0034C938
				// (set) Token: 0x0600E105 RID: 57605 RVA: 0x0006DB80 File Offset: 0x0006BD80
				public unsafe RenderTextureDescriptor cameraTargetDescriptor
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_cameraTargetDescriptor);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_cameraTargetDescriptor)) = value;
					}
				}

				// Token: 0x040096A8 RID: 38568
				private static readonly IntPtr NativeFieldInfoPtr_cam;

				// Token: 0x040096A9 RID: 38569
				private static readonly IntPtr NativeFieldInfoPtr_cmd;

				// Token: 0x040096AA RID: 38570
				private static readonly IntPtr NativeFieldInfoPtr_depthPass;

				// Token: 0x040096AB RID: 38571
				private static readonly IntPtr NativeFieldInfoPtr_mat;

				// Token: 0x040096AC RID: 38572
				private static readonly IntPtr NativeFieldInfoPtr_source;

				// Token: 0x040096AD RID: 38573
				private static readonly IntPtr NativeFieldInfoPtr_depth;

				// Token: 0x040096AE RID: 38574
				private static readonly IntPtr NativeFieldInfoPtr_cameraTargetDescriptor;

				// Token: 0x040096AF RID: 38575
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
			}
		}
	}
}
