using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Packaging
{
	// Token: 0x02000568 RID: 1384
	public class FilledPackagingVisuals : MonoBehaviour
	{
		// Token: 0x060079A1 RID: 31137 RVA: 0x0020C2F8 File Offset: 0x0020A4F8
		// Note: this type is marked as 'beforefieldinit'.
		static FilledPackagingVisuals()
		{
			Il2CppClassPointerStore<FilledPackagingVisuals>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Packaging", "FilledPackagingVisuals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilledPackagingVisuals>.NativeClassPtr);
			FilledPackagingVisuals.NativeFieldInfoPtr_weedVisuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilledPackagingVisuals>.NativeClassPtr, "weedVisuals");
			FilledPackagingVisuals.NativeFieldInfoPtr_methVisuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilledPackagingVisuals>.NativeClassPtr, "methVisuals");
			FilledPackagingVisuals.NativeFieldInfoPtr_cocaineVisuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilledPackagingVisuals>.NativeClassPtr, "cocaineVisuals");
			FilledPackagingVisuals.NativeMethodInfoPtr_ResetVisuals_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilledPackagingVisuals>.NativeClassPtr, 100678520);
			FilledPackagingVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilledPackagingVisuals>.NativeClassPtr, 100678521);
		}

		// Token: 0x060079A2 RID: 31138 RVA: 0x0020C38C File Offset: 0x0020A58C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 233160, RefRangeEnd = 233163, XrefRangeStart = 233144, XrefRangeEnd = 233160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilledPackagingVisuals.NativeMethodInfoPtr_ResetVisuals_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079A3 RID: 31139 RVA: 0x0020C3C0 File Offset: 0x0020A5C0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FilledPackagingVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilledPackagingVisuals>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilledPackagingVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079A4 RID: 31140 RVA: 0x00039E1A File Offset: 0x0003801A
		public FilledPackagingVisuals(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024D1 RID: 9425
		// (get) Token: 0x060079A5 RID: 31141 RVA: 0x0020C3FC File Offset: 0x0020A5FC
		// (set) Token: 0x060079A6 RID: 31142 RVA: 0x00039E23 File Offset: 0x00038023
		public unsafe FilledPackagingVisuals.WeedVisuals weedVisuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.NativeFieldInfoPtr_weedVisuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilledPackagingVisuals.WeedVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.NativeFieldInfoPtr_weedVisuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024D2 RID: 9426
		// (get) Token: 0x060079A7 RID: 31143 RVA: 0x0020C42C File Offset: 0x0020A62C
		// (set) Token: 0x060079A8 RID: 31144 RVA: 0x00039E42 File Offset: 0x00038042
		public unsafe FilledPackagingVisuals.MethVisuals methVisuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.NativeFieldInfoPtr_methVisuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilledPackagingVisuals.MethVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.NativeFieldInfoPtr_methVisuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024D3 RID: 9427
		// (get) Token: 0x060079A9 RID: 31145 RVA: 0x0020C45C File Offset: 0x0020A65C
		// (set) Token: 0x060079AA RID: 31146 RVA: 0x00039E61 File Offset: 0x00038061
		public unsafe FilledPackagingVisuals.CocaineVisuals cocaineVisuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.NativeFieldInfoPtr_cocaineVisuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilledPackagingVisuals.CocaineVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.NativeFieldInfoPtr_cocaineVisuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040052C2 RID: 21186
		private static readonly IntPtr NativeFieldInfoPtr_weedVisuals;

		// Token: 0x040052C3 RID: 21187
		private static readonly IntPtr NativeFieldInfoPtr_methVisuals;

		// Token: 0x040052C4 RID: 21188
		private static readonly IntPtr NativeFieldInfoPtr_cocaineVisuals;

		// Token: 0x040052C5 RID: 21189
		private static readonly IntPtr NativeMethodInfoPtr_ResetVisuals_Public_Void_0;

		// Token: 0x040052C6 RID: 21190
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AAB RID: 2731
		[Serializable]
		public class MeshIndexPair : Il2CppSystem.Object
		{
			// Token: 0x0600D369 RID: 54121 RVA: 0x00328220 File Offset: 0x00326420
			// Note: this type is marked as 'beforefieldinit'.
			static MeshIndexPair()
			{
				Il2CppClassPointerStore<FilledPackagingVisuals.MeshIndexPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilledPackagingVisuals>.NativeClassPtr, "MeshIndexPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilledPackagingVisuals.MeshIndexPair>.NativeClassPtr);
				FilledPackagingVisuals.MeshIndexPair.NativeFieldInfoPtr_Mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilledPackagingVisuals.MeshIndexPair>.NativeClassPtr, "Mesh");
				FilledPackagingVisuals.MeshIndexPair.NativeFieldInfoPtr_MaterialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilledPackagingVisuals.MeshIndexPair>.NativeClassPtr, "MaterialIndex");
				FilledPackagingVisuals.MeshIndexPair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilledPackagingVisuals.MeshIndexPair>.NativeClassPtr, 100678522);
			}

			// Token: 0x0600D36A RID: 54122 RVA: 0x00328288 File Offset: 0x00326488
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MeshIndexPair() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilledPackagingVisuals.MeshIndexPair>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilledPackagingVisuals.MeshIndexPair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D36B RID: 54123 RVA: 0x00066E9E File Offset: 0x0006509E
			public MeshIndexPair(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004191 RID: 16785
			// (get) Token: 0x0600D36C RID: 54124 RVA: 0x003282C4 File Offset: 0x003264C4
			// (set) Token: 0x0600D36D RID: 54125 RVA: 0x00066EA7 File Offset: 0x000650A7
			public unsafe MeshRenderer Mesh
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.MeshIndexPair.NativeFieldInfoPtr_Mesh);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.MeshIndexPair.NativeFieldInfoPtr_Mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004192 RID: 16786
			// (get) Token: 0x0600D36E RID: 54126 RVA: 0x003282F4 File Offset: 0x003264F4
			// (set) Token: 0x0600D36F RID: 54127 RVA: 0x00066EC6 File Offset: 0x000650C6
			public unsafe int MaterialIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.MeshIndexPair.NativeFieldInfoPtr_MaterialIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.MeshIndexPair.NativeFieldInfoPtr_MaterialIndex)) = value;
				}
			}

			// Token: 0x04008E6D RID: 36461
			private static readonly IntPtr NativeFieldInfoPtr_Mesh;

			// Token: 0x04008E6E RID: 36462
			private static readonly IntPtr NativeFieldInfoPtr_MaterialIndex;

			// Token: 0x04008E6F RID: 36463
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AAC RID: 2732
		[Serializable]
		public class BaseVisuals : Il2CppSystem.Object
		{
			// Token: 0x0600D370 RID: 54128 RVA: 0x0032831C File Offset: 0x0032651C
			// Note: this type is marked as 'beforefieldinit'.
			static BaseVisuals()
			{
				Il2CppClassPointerStore<FilledPackagingVisuals.BaseVisuals>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilledPackagingVisuals>.NativeClassPtr, "BaseVisuals");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilledPackagingVisuals.BaseVisuals>.NativeClassPtr);
				FilledPackagingVisuals.BaseVisuals.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilledPackagingVisuals.BaseVisuals>.NativeClassPtr, "Container");
				FilledPackagingVisuals.BaseVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilledPackagingVisuals.BaseVisuals>.NativeClassPtr, 100678523);
			}

			// Token: 0x0600D371 RID: 54129 RVA: 0x00328370 File Offset: 0x00326570
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BaseVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilledPackagingVisuals.BaseVisuals>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilledPackagingVisuals.BaseVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D372 RID: 54130 RVA: 0x00066EE1 File Offset: 0x000650E1
			public BaseVisuals(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004193 RID: 16787
			// (get) Token: 0x0600D373 RID: 54131 RVA: 0x003283AC File Offset: 0x003265AC
			// (set) Token: 0x0600D374 RID: 54132 RVA: 0x00066EEA File Offset: 0x000650EA
			public unsafe Transform Container
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.BaseVisuals.NativeFieldInfoPtr_Container);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.BaseVisuals.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E70 RID: 36464
			private static readonly IntPtr NativeFieldInfoPtr_Container;

			// Token: 0x04008E71 RID: 36465
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AAD RID: 2733
		[Serializable]
		public class WeedVisuals : FilledPackagingVisuals.BaseVisuals
		{
			// Token: 0x0600D375 RID: 54133 RVA: 0x003283DC File Offset: 0x003265DC
			// Note: this type is marked as 'beforefieldinit'.
			static WeedVisuals()
			{
				Il2CppClassPointerStore<FilledPackagingVisuals.WeedVisuals>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilledPackagingVisuals>.NativeClassPtr, "WeedVisuals");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilledPackagingVisuals.WeedVisuals>.NativeClassPtr);
				FilledPackagingVisuals.WeedVisuals.NativeFieldInfoPtr_MainMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilledPackagingVisuals.WeedVisuals>.NativeClassPtr, "MainMeshes");
				FilledPackagingVisuals.WeedVisuals.NativeFieldInfoPtr_SecondaryMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilledPackagingVisuals.WeedVisuals>.NativeClassPtr, "SecondaryMeshes");
				FilledPackagingVisuals.WeedVisuals.NativeFieldInfoPtr_LeafMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilledPackagingVisuals.WeedVisuals>.NativeClassPtr, "LeafMeshes");
				FilledPackagingVisuals.WeedVisuals.NativeFieldInfoPtr_StemMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilledPackagingVisuals.WeedVisuals>.NativeClassPtr, "StemMeshes");
				FilledPackagingVisuals.WeedVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilledPackagingVisuals.WeedVisuals>.NativeClassPtr, 100678524);
			}

			// Token: 0x0600D376 RID: 54134 RVA: 0x0032846C File Offset: 0x0032666C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WeedVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilledPackagingVisuals.WeedVisuals>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilledPackagingVisuals.WeedVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D377 RID: 54135 RVA: 0x00066F09 File Offset: 0x00065109
			public WeedVisuals(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004194 RID: 16788
			// (get) Token: 0x0600D378 RID: 54136 RVA: 0x003284A8 File Offset: 0x003266A8
			// (set) Token: 0x0600D379 RID: 54137 RVA: 0x00066F12 File Offset: 0x00065112
			public unsafe Il2CppReferenceArray<FilledPackagingVisuals.MeshIndexPair> MainMeshes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.WeedVisuals.NativeFieldInfoPtr_MainMeshes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FilledPackagingVisuals.MeshIndexPair>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.WeedVisuals.NativeFieldInfoPtr_MainMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004195 RID: 16789
			// (get) Token: 0x0600D37A RID: 54138 RVA: 0x003284D8 File Offset: 0x003266D8
			// (set) Token: 0x0600D37B RID: 54139 RVA: 0x00066F31 File Offset: 0x00065131
			public unsafe Il2CppReferenceArray<FilledPackagingVisuals.MeshIndexPair> SecondaryMeshes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.WeedVisuals.NativeFieldInfoPtr_SecondaryMeshes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FilledPackagingVisuals.MeshIndexPair>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.WeedVisuals.NativeFieldInfoPtr_SecondaryMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004196 RID: 16790
			// (get) Token: 0x0600D37C RID: 54140 RVA: 0x00328508 File Offset: 0x00326708
			// (set) Token: 0x0600D37D RID: 54141 RVA: 0x00066F50 File Offset: 0x00065150
			public unsafe Il2CppReferenceArray<FilledPackagingVisuals.MeshIndexPair> LeafMeshes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.WeedVisuals.NativeFieldInfoPtr_LeafMeshes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FilledPackagingVisuals.MeshIndexPair>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.WeedVisuals.NativeFieldInfoPtr_LeafMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004197 RID: 16791
			// (get) Token: 0x0600D37E RID: 54142 RVA: 0x00328538 File Offset: 0x00326738
			// (set) Token: 0x0600D37F RID: 54143 RVA: 0x00066F6F File Offset: 0x0006516F
			public unsafe Il2CppReferenceArray<FilledPackagingVisuals.MeshIndexPair> StemMeshes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.WeedVisuals.NativeFieldInfoPtr_StemMeshes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FilledPackagingVisuals.MeshIndexPair>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.WeedVisuals.NativeFieldInfoPtr_StemMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E72 RID: 36466
			private static readonly IntPtr NativeFieldInfoPtr_MainMeshes;

			// Token: 0x04008E73 RID: 36467
			private static readonly IntPtr NativeFieldInfoPtr_SecondaryMeshes;

			// Token: 0x04008E74 RID: 36468
			private static readonly IntPtr NativeFieldInfoPtr_LeafMeshes;

			// Token: 0x04008E75 RID: 36469
			private static readonly IntPtr NativeFieldInfoPtr_StemMeshes;

			// Token: 0x04008E76 RID: 36470
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AAE RID: 2734
		[Serializable]
		public class MethVisuals : FilledPackagingVisuals.BaseVisuals
		{
			// Token: 0x0600D380 RID: 54144 RVA: 0x00328568 File Offset: 0x00326768
			// Note: this type is marked as 'beforefieldinit'.
			static MethVisuals()
			{
				Il2CppClassPointerStore<FilledPackagingVisuals.MethVisuals>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilledPackagingVisuals>.NativeClassPtr, "MethVisuals");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilledPackagingVisuals.MethVisuals>.NativeClassPtr);
				FilledPackagingVisuals.MethVisuals.NativeFieldInfoPtr_CrystalMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilledPackagingVisuals.MethVisuals>.NativeClassPtr, "CrystalMeshes");
				FilledPackagingVisuals.MethVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilledPackagingVisuals.MethVisuals>.NativeClassPtr, 100678525);
			}

			// Token: 0x0600D381 RID: 54145 RVA: 0x003285BC File Offset: 0x003267BC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MethVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilledPackagingVisuals.MethVisuals>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilledPackagingVisuals.MethVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D382 RID: 54146 RVA: 0x00066F8E File Offset: 0x0006518E
			public MethVisuals(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004198 RID: 16792
			// (get) Token: 0x0600D383 RID: 54147 RVA: 0x003285F8 File Offset: 0x003267F8
			// (set) Token: 0x0600D384 RID: 54148 RVA: 0x00066F97 File Offset: 0x00065197
			public unsafe Il2CppReferenceArray<MeshRenderer> CrystalMeshes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.MethVisuals.NativeFieldInfoPtr_CrystalMeshes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.MethVisuals.NativeFieldInfoPtr_CrystalMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E77 RID: 36471
			private static readonly IntPtr NativeFieldInfoPtr_CrystalMeshes;

			// Token: 0x04008E78 RID: 36472
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AAF RID: 2735
		[Serializable]
		public class CocaineVisuals : FilledPackagingVisuals.BaseVisuals
		{
			// Token: 0x0600D385 RID: 54149 RVA: 0x00328628 File Offset: 0x00326828
			// Note: this type is marked as 'beforefieldinit'.
			static CocaineVisuals()
			{
				Il2CppClassPointerStore<FilledPackagingVisuals.CocaineVisuals>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilledPackagingVisuals>.NativeClassPtr, "CocaineVisuals");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilledPackagingVisuals.CocaineVisuals>.NativeClassPtr);
				FilledPackagingVisuals.CocaineVisuals.NativeFieldInfoPtr_RockMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilledPackagingVisuals.CocaineVisuals>.NativeClassPtr, "RockMeshes");
				FilledPackagingVisuals.CocaineVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilledPackagingVisuals.CocaineVisuals>.NativeClassPtr, 100678526);
			}

			// Token: 0x0600D386 RID: 54150 RVA: 0x0032867C File Offset: 0x0032687C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CocaineVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilledPackagingVisuals.CocaineVisuals>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilledPackagingVisuals.CocaineVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D387 RID: 54151 RVA: 0x00066FB6 File Offset: 0x000651B6
			public CocaineVisuals(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004199 RID: 16793
			// (get) Token: 0x0600D388 RID: 54152 RVA: 0x003286B8 File Offset: 0x003268B8
			// (set) Token: 0x0600D389 RID: 54153 RVA: 0x00066FBF File Offset: 0x000651BF
			public unsafe Il2CppReferenceArray<MeshRenderer> RockMeshes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.CocaineVisuals.NativeFieldInfoPtr_RockMeshes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.CocaineVisuals.NativeFieldInfoPtr_RockMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E79 RID: 36473
			private static readonly IntPtr NativeFieldInfoPtr_RockMeshes;

			// Token: 0x04008E7A RID: 36474
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
