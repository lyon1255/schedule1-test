using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.Modification
{
	// Token: 0x020004F9 RID: 1273
	public class VehicleColors : Singleton<VehicleColors>
	{
		// Token: 0x06007089 RID: 28809 RVA: 0x001EEB5C File Offset: 0x001ECD5C
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleColors()
		{
			Il2CppClassPointerStore<VehicleColors>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.Modification", "VehicleColors");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleColors>.NativeClassPtr);
			VehicleColors.NativeFieldInfoPtr_colorLibrary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleColors>.NativeClassPtr, "colorLibrary");
			VehicleColors.NativeMethodInfoPtr_GetColorName_Public_String_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleColors>.NativeClassPtr, 100677436);
			VehicleColors.NativeMethodInfoPtr_GetColorUIColor_Public_Color32_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleColors>.NativeClassPtr, 100677437);
			VehicleColors.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleColors>.NativeClassPtr, 100677438);
		}

		// Token: 0x0600708A RID: 28810 RVA: 0x001EEBDC File Offset: 0x001ECDDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221537, XrefRangeEnd = 221550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetColorName(EVehicleColor c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref c;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleColors.NativeMethodInfoPtr_GetColorName_Public_String_EVehicleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600708B RID: 28811 RVA: 0x001EEC20 File Offset: 0x001ECE20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221550, XrefRangeEnd = 221563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color32 GetColorUIColor(EVehicleColor c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref c;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleColors.NativeMethodInfoPtr_GetColorUIColor_Public_Color32_EVehicleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600708C RID: 28812 RVA: 0x001EEC6C File Offset: 0x001ECE6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221563, XrefRangeEnd = 221573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleColors() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleColors>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleColors.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600708D RID: 28813 RVA: 0x000356D8 File Offset: 0x000338D8
		public VehicleColors(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002203 RID: 8707
		// (get) Token: 0x0600708E RID: 28814 RVA: 0x001EECA8 File Offset: 0x001ECEA8
		// (set) Token: 0x0600708F RID: 28815 RVA: 0x000356E1 File Offset: 0x000338E1
		public unsafe List<VehicleColors.VehicleColorData> colorLibrary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.NativeFieldInfoPtr_colorLibrary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VehicleColors.VehicleColorData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.NativeFieldInfoPtr_colorLibrary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004CEA RID: 19690
		private static readonly IntPtr NativeFieldInfoPtr_colorLibrary;

		// Token: 0x04004CEB RID: 19691
		private static readonly IntPtr NativeMethodInfoPtr_GetColorName_Public_String_EVehicleColor_0;

		// Token: 0x04004CEC RID: 19692
		private static readonly IntPtr NativeMethodInfoPtr_GetColorUIColor_Public_Color32_EVehicleColor_0;

		// Token: 0x04004CED RID: 19693
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A6D RID: 2669
		[Serializable]
		public class VehicleColorData : Il2CppSystem.Object
		{
			// Token: 0x0600D129 RID: 53545 RVA: 0x00321C04 File Offset: 0x0031FE04
			// Note: this type is marked as 'beforefieldinit'.
			static VehicleColorData()
			{
				Il2CppClassPointerStore<VehicleColors.VehicleColorData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleColors>.NativeClassPtr, "VehicleColorData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleColors.VehicleColorData>.NativeClassPtr);
				VehicleColors.VehicleColorData.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleColors.VehicleColorData>.NativeClassPtr, "color");
				VehicleColors.VehicleColorData.NativeFieldInfoPtr_colorName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleColors.VehicleColorData>.NativeClassPtr, "colorName");
				VehicleColors.VehicleColorData.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleColors.VehicleColorData>.NativeClassPtr, "material");
				VehicleColors.VehicleColorData.NativeFieldInfoPtr_UIColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleColors.VehicleColorData>.NativeClassPtr, "UIColor");
				VehicleColors.VehicleColorData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleColors.VehicleColorData>.NativeClassPtr, 100677439);
			}

			// Token: 0x0600D12A RID: 53546 RVA: 0x00321C94 File Offset: 0x0031FE94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221535, XrefRangeEnd = 221537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe VehicleColorData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleColors.VehicleColorData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleColors.VehicleColorData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D12B RID: 53547 RVA: 0x00065D33 File Offset: 0x00063F33
			public VehicleColorData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040F2 RID: 16626
			// (get) Token: 0x0600D12C RID: 53548 RVA: 0x00321CD0 File Offset: 0x0031FED0
			// (set) Token: 0x0600D12D RID: 53549 RVA: 0x00065D3C File Offset: 0x00063F3C
			public unsafe EVehicleColor color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.VehicleColorData.NativeFieldInfoPtr_color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.VehicleColorData.NativeFieldInfoPtr_color)) = value;
				}
			}

			// Token: 0x170040F3 RID: 16627
			// (get) Token: 0x0600D12E RID: 53550 RVA: 0x00321CF8 File Offset: 0x0031FEF8
			// (set) Token: 0x0600D12F RID: 53551 RVA: 0x00065D57 File Offset: 0x00063F57
			public unsafe string colorName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.VehicleColorData.NativeFieldInfoPtr_colorName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.VehicleColorData.NativeFieldInfoPtr_colorName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170040F4 RID: 16628
			// (get) Token: 0x0600D130 RID: 53552 RVA: 0x00321D20 File Offset: 0x0031FF20
			// (set) Token: 0x0600D131 RID: 53553 RVA: 0x00065D76 File Offset: 0x00063F76
			public unsafe Material material
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.VehicleColorData.NativeFieldInfoPtr_material);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.VehicleColorData.NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040F5 RID: 16629
			// (get) Token: 0x0600D132 RID: 53554 RVA: 0x00321D50 File Offset: 0x0031FF50
			// (set) Token: 0x0600D133 RID: 53555 RVA: 0x00065D95 File Offset: 0x00063F95
			public unsafe Color32 UIColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.VehicleColorData.NativeFieldInfoPtr_UIColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.VehicleColorData.NativeFieldInfoPtr_UIColor)) = value;
				}
			}

			// Token: 0x04008D1E RID: 36126
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x04008D1F RID: 36127
			private static readonly IntPtr NativeFieldInfoPtr_colorName;

			// Token: 0x04008D20 RID: 36128
			private static readonly IntPtr NativeFieldInfoPtr_material;

			// Token: 0x04008D21 RID: 36129
			private static readonly IntPtr NativeFieldInfoPtr_UIColor;

			// Token: 0x04008D22 RID: 36130
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A6E RID: 2670
		[ObfuscatedName("ScheduleOne.Vehicles.Modification.VehicleColors+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D134 RID: 53556 RVA: 0x00321D78 File Offset: 0x0031FF78
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<VehicleColors.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleColors>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleColors.__c__DisplayClass2_0>.NativeClassPtr);
				VehicleColors.__c__DisplayClass2_0.NativeFieldInfoPtr_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleColors.__c__DisplayClass2_0>.NativeClassPtr, "c");
				VehicleColors.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleColors.__c__DisplayClass2_0>.NativeClassPtr, 100677440);
				VehicleColors.__c__DisplayClass2_0.NativeMethodInfoPtr__GetColorName_b__0_Internal_Boolean_VehicleColorData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleColors.__c__DisplayClass2_0>.NativeClassPtr, 100677441);
			}

			// Token: 0x0600D135 RID: 53557 RVA: 0x00321DE0 File Offset: 0x0031FFE0
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleColors.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleColors.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D136 RID: 53558 RVA: 0x00321E1C File Offset: 0x0032001C
			[CallerCount(0)]
			public unsafe bool _GetColorName_b__0(VehicleColors.VehicleColorData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleColors.__c__DisplayClass2_0.NativeMethodInfoPtr__GetColorName_b__0_Internal_Boolean_VehicleColorData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D137 RID: 53559 RVA: 0x00065DB0 File Offset: 0x00063FB0
			public __c__DisplayClass2_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040F6 RID: 16630
			// (get) Token: 0x0600D138 RID: 53560 RVA: 0x00321E6C File Offset: 0x0032006C
			// (set) Token: 0x0600D139 RID: 53561 RVA: 0x00065DB9 File Offset: 0x00063FB9
			public unsafe EVehicleColor c
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.__c__DisplayClass2_0.NativeFieldInfoPtr_c);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.__c__DisplayClass2_0.NativeFieldInfoPtr_c)) = value;
				}
			}

			// Token: 0x04008D23 RID: 36131
			private static readonly IntPtr NativeFieldInfoPtr_c;

			// Token: 0x04008D24 RID: 36132
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008D25 RID: 36133
			private static readonly IntPtr NativeMethodInfoPtr__GetColorName_b__0_Internal_Boolean_VehicleColorData_0;
		}

		// Token: 0x02000A6F RID: 2671
		[ObfuscatedName("ScheduleOne.Vehicles.Modification.VehicleColors+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D13A RID: 53562 RVA: 0x00321E94 File Offset: 0x00320094
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<VehicleColors.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleColors>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleColors.__c__DisplayClass3_0>.NativeClassPtr);
				VehicleColors.__c__DisplayClass3_0.NativeFieldInfoPtr_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleColors.__c__DisplayClass3_0>.NativeClassPtr, "c");
				VehicleColors.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleColors.__c__DisplayClass3_0>.NativeClassPtr, 100677442);
				VehicleColors.__c__DisplayClass3_0.NativeMethodInfoPtr__GetColorUIColor_b__0_Internal_Boolean_VehicleColorData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleColors.__c__DisplayClass3_0>.NativeClassPtr, 100677443);
			}

			// Token: 0x0600D13B RID: 53563 RVA: 0x00321EFC File Offset: 0x003200FC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleColors.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleColors.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D13C RID: 53564 RVA: 0x00321F38 File Offset: 0x00320138
			[CallerCount(0)]
			public unsafe bool _GetColorUIColor_b__0(VehicleColors.VehicleColorData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleColors.__c__DisplayClass3_0.NativeMethodInfoPtr__GetColorUIColor_b__0_Internal_Boolean_VehicleColorData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D13D RID: 53565 RVA: 0x00065DD4 File Offset: 0x00063FD4
			public __c__DisplayClass3_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040F7 RID: 16631
			// (get) Token: 0x0600D13E RID: 53566 RVA: 0x00321F88 File Offset: 0x00320188
			// (set) Token: 0x0600D13F RID: 53567 RVA: 0x00065DDD File Offset: 0x00063FDD
			public unsafe EVehicleColor c
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.__c__DisplayClass3_0.NativeFieldInfoPtr_c);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.__c__DisplayClass3_0.NativeFieldInfoPtr_c)) = value;
				}
			}

			// Token: 0x04008D26 RID: 36134
			private static readonly IntPtr NativeFieldInfoPtr_c;

			// Token: 0x04008D27 RID: 36135
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008D28 RID: 36136
			private static readonly IntPtr NativeMethodInfoPtr__GetColorUIColor_b__0_Internal_Boolean_VehicleColorData_0;
		}
	}
}
