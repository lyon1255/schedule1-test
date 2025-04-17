using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Rendering;

namespace Il2Cpp
{
	// Token: 0x02000046 RID: 70
	public class VolumetricFire : MonoBehaviour
	{
		// Token: 0x060005D9 RID: 1497 RVA: 0x00081CE8 File Offset: 0x0007FEE8
		// Note: this type is marked as 'beforefieldinit'.
		static VolumetricFire()
		{
			Il2CppClassPointerStore<VolumetricFire>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "VolumetricFire");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumetricFire>.NativeClassPtr);
			VolumetricFire.NativeFieldInfoPtr_mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricFire>.NativeClassPtr, "mesh");
			VolumetricFire.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricFire>.NativeClassPtr, "material");
			VolumetricFire.NativeFieldInfoPtr_thickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricFire>.NativeClassPtr, "thickness");
			VolumetricFire.NativeFieldInfoPtr_spread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricFire>.NativeClassPtr, "spread");
			VolumetricFire.NativeFieldInfoPtr_billboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricFire>.NativeClassPtr, "billboard");
			VolumetricFire.NativeFieldInfoPtr_materialPropertyBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricFire>.NativeClassPtr, "materialPropertyBlock");
			VolumetricFire.NativeFieldInfoPtr_internalCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricFire>.NativeClassPtr, "internalCount");
			VolumetricFire.NativeFieldInfoPtr_randomStatic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricFire>.NativeClassPtr, "randomStatic");
			VolumetricFire.NativeFieldInfoPtr_boundaryCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricFire>.NativeClassPtr, "boundaryCollider");
			VolumetricFire.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricFire>.NativeClassPtr, 100663851);
			VolumetricFire.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricFire>.NativeClassPtr, 100663852);
			VolumetricFire.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricFire>.NativeClassPtr, 100663853);
			VolumetricFire.NativeMethodInfoPtr_IsVisible_Private_Static_Boolean_Camera_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricFire>.NativeClassPtr, 100663854);
			VolumetricFire.NativeMethodInfoPtr_RenderFlames_Private_Void_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricFire>.NativeClassPtr, 100663855);
			VolumetricFire.NativeMethodInfoPtr_SetupMaterialPropertyBlock_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricFire>.NativeClassPtr, 100663856);
			VolumetricFire.NativeMethodInfoPtr_CreateItem_Private_Void_Single_Single_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricFire>.NativeClassPtr, 100663857);
			VolumetricFire.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricFire>.NativeClassPtr, 100663858);
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00081E6C File Offset: 0x0008006C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75617, XrefRangeEnd = 75638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricFire.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00081EA0 File Offset: 0x000800A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75638, XrefRangeEnd = 75648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricFire.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00081ED4 File Offset: 0x000800D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75648, XrefRangeEnd = 75658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricFire.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00081F08 File Offset: 0x00080108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75658, XrefRangeEnd = 75660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsVisible(Camera camera, Bounds bounds)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bounds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricFire.NativeMethodInfoPtr_IsVisible_Private_Static_Boolean_Camera_Bounds_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00081F58 File Offset: 0x00080158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75660, XrefRangeEnd = 75673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderFlames(ScriptableRenderContext context, Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref context;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricFire.NativeMethodInfoPtr_RenderFlames_Private_Void_ScriptableRenderContext_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x00081FA8 File Offset: 0x000801A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75673, XrefRangeEnd = 75682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupMaterialPropertyBlock(float item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref item;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricFire.NativeMethodInfoPtr_SetupMaterialPropertyBlock_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00081FE8 File Offset: 0x000801E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 75715, RefRangeEnd = 75716, XrefRangeStart = 75682, XrefRangeEnd = 75715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateItem(float spacing, float item, Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref spacing;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref item;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricFire.NativeMethodInfoPtr_CreateItem_Private_Void_Single_Single_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00082048 File Offset: 0x00080248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75716, XrefRangeEnd = 75733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumetricFire() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumetricFire>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricFire.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x000056EB File Offset: 0x000038EB
		public VolumetricFire(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060005E3 RID: 1507 RVA: 0x00082084 File Offset: 0x00080284
		// (set) Token: 0x060005E4 RID: 1508 RVA: 0x000056F4 File Offset: 0x000038F4
		public unsafe Mesh mesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricFire.NativeFieldInfoPtr_mesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricFire.NativeFieldInfoPtr_mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060005E5 RID: 1509 RVA: 0x000820B4 File Offset: 0x000802B4
		// (set) Token: 0x060005E6 RID: 1510 RVA: 0x00005713 File Offset: 0x00003913
		public unsafe Material material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricFire.NativeFieldInfoPtr_material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricFire.NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060005E7 RID: 1511 RVA: 0x000820E4 File Offset: 0x000802E4
		// (set) Token: 0x060005E8 RID: 1512 RVA: 0x00005732 File Offset: 0x00003932
		public unsafe int thickness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricFire.NativeFieldInfoPtr_thickness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricFire.NativeFieldInfoPtr_thickness)) = value;
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060005E9 RID: 1513 RVA: 0x0008210C File Offset: 0x0008030C
		// (set) Token: 0x060005EA RID: 1514 RVA: 0x0000574D File Offset: 0x0000394D
		public unsafe float spread
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricFire.NativeFieldInfoPtr_spread);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricFire.NativeFieldInfoPtr_spread)) = value;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x00082134 File Offset: 0x00080334
		// (set) Token: 0x060005EC RID: 1516 RVA: 0x00005768 File Offset: 0x00003968
		public unsafe bool billboard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricFire.NativeFieldInfoPtr_billboard);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricFire.NativeFieldInfoPtr_billboard)) = value;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x0008215C File Offset: 0x0008035C
		// (set) Token: 0x060005EE RID: 1518 RVA: 0x00005783 File Offset: 0x00003983
		public unsafe MaterialPropertyBlock materialPropertyBlock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricFire.NativeFieldInfoPtr_materialPropertyBlock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaterialPropertyBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricFire.NativeFieldInfoPtr_materialPropertyBlock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060005EF RID: 1519 RVA: 0x0008218C File Offset: 0x0008038C
		// (set) Token: 0x060005F0 RID: 1520 RVA: 0x000057A2 File Offset: 0x000039A2
		public unsafe int internalCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricFire.NativeFieldInfoPtr_internalCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricFire.NativeFieldInfoPtr_internalCount)) = value;
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060005F1 RID: 1521 RVA: 0x000821B4 File Offset: 0x000803B4
		// (set) Token: 0x060005F2 RID: 1522 RVA: 0x000057BD File Offset: 0x000039BD
		public unsafe float randomStatic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricFire.NativeFieldInfoPtr_randomStatic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricFire.NativeFieldInfoPtr_randomStatic)) = value;
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060005F3 RID: 1523 RVA: 0x000821DC File Offset: 0x000803DC
		// (set) Token: 0x060005F4 RID: 1524 RVA: 0x000057D8 File Offset: 0x000039D8
		public unsafe Collider boundaryCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricFire.NativeFieldInfoPtr_boundaryCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricFire.NativeFieldInfoPtr_boundaryCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400037F RID: 895
		private static readonly IntPtr NativeFieldInfoPtr_mesh;

		// Token: 0x04000380 RID: 896
		private static readonly IntPtr NativeFieldInfoPtr_material;

		// Token: 0x04000381 RID: 897
		private static readonly IntPtr NativeFieldInfoPtr_thickness;

		// Token: 0x04000382 RID: 898
		private static readonly IntPtr NativeFieldInfoPtr_spread;

		// Token: 0x04000383 RID: 899
		private static readonly IntPtr NativeFieldInfoPtr_billboard;

		// Token: 0x04000384 RID: 900
		private static readonly IntPtr NativeFieldInfoPtr_materialPropertyBlock;

		// Token: 0x04000385 RID: 901
		private static readonly IntPtr NativeFieldInfoPtr_internalCount;

		// Token: 0x04000386 RID: 902
		private static readonly IntPtr NativeFieldInfoPtr_randomStatic;

		// Token: 0x04000387 RID: 903
		private static readonly IntPtr NativeFieldInfoPtr_boundaryCollider;

		// Token: 0x04000388 RID: 904
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000389 RID: 905
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400038A RID: 906
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x0400038B RID: 907
		private static readonly IntPtr NativeMethodInfoPtr_IsVisible_Private_Static_Boolean_Camera_Bounds_0;

		// Token: 0x0400038C RID: 908
		private static readonly IntPtr NativeMethodInfoPtr_RenderFlames_Private_Void_ScriptableRenderContext_Camera_0;

		// Token: 0x0400038D RID: 909
		private static readonly IntPtr NativeMethodInfoPtr_SetupMaterialPropertyBlock_Private_Void_Single_0;

		// Token: 0x0400038E RID: 910
		private static readonly IntPtr NativeMethodInfoPtr_CreateItem_Private_Void_Single_Single_Camera_0;

		// Token: 0x0400038F RID: 911
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
