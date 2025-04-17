using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x02000587 RID: 1415
	public class Fillable : MonoBehaviour
	{
		// Token: 0x06007C9C RID: 31900 RVA: 0x0021746C File Offset: 0x0021566C
		// Note: this type is marked as 'beforefieldinit'.
		static Fillable()
		{
			Il2CppClassPointerStore<Fillable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "Fillable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Fillable>.NativeClassPtr);
			Fillable.NativeFieldInfoPtr__contents_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable>.NativeClassPtr, "<contents>k__BackingField");
			Fillable.NativeFieldInfoPtr_LiquidContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable>.NativeClassPtr, "LiquidContainer");
			Fillable.NativeFieldInfoPtr_FillableEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable>.NativeClassPtr, "FillableEnabled");
			Fillable.NativeFieldInfoPtr_LiquidCapacity_L = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable>.NativeClassPtr, "LiquidCapacity_L");
			Fillable.NativeMethodInfoPtr_get_contents_Public_get_List_1_Content_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable>.NativeClassPtr, 100678899);
			Fillable.NativeMethodInfoPtr_set_contents_Protected_set_Void_List_1_Content_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable>.NativeClassPtr, 100678900);
			Fillable.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable>.NativeClassPtr, 100678901);
			Fillable.NativeMethodInfoPtr_AddLiquid_Public_Void_String_Single_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable>.NativeClassPtr, 100678902);
			Fillable.NativeMethodInfoPtr_ResetContents_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable>.NativeClassPtr, 100678903);
			Fillable.NativeMethodInfoPtr_UpdateLiquid_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable>.NativeClassPtr, 100678904);
			Fillable.NativeMethodInfoPtr_GetLiquidVolume_Public_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable>.NativeClassPtr, 100678905);
			Fillable.NativeMethodInfoPtr_GetTotalLiquidVolume_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable>.NativeClassPtr, 100678906);
			Fillable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable>.NativeClassPtr, 100678907);
		}

		// Token: 0x170025B4 RID: 9652
		// (get) Token: 0x06007C9D RID: 31901 RVA: 0x002175A0 File Offset: 0x002157A0
		// (set) Token: 0x06007C9E RID: 31902 RVA: 0x002175E0 File Offset: 0x002157E0
		public unsafe List<Fillable.Content> contents
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17402, RefRangeEnd = 17403, XrefRangeStart = 17402, XrefRangeEnd = 17403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.NativeMethodInfoPtr_get_contents_Public_get_List_1_Content_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Fillable.Content>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.NativeMethodInfoPtr_set_contents_Protected_set_Void_List_1_Content_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007C9F RID: 31903 RVA: 0x00217624 File Offset: 0x00215824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237258, XrefRangeEnd = 237260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CA0 RID: 31904 RVA: 0x00217658 File Offset: 0x00215858
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 237287, RefRangeEnd = 237290, XrefRangeStart = 237260, XrefRangeEnd = 237287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddLiquid(string label, float volume, Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volume;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.NativeMethodInfoPtr_AddLiquid_Public_Void_String_Single_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CA1 RID: 31905 RVA: 0x002176B8 File Offset: 0x002158B8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 237294, RefRangeEnd = 237300, XrefRangeStart = 237290, XrefRangeEnd = 237294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetContents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.NativeMethodInfoPtr_ResetContents_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CA2 RID: 31906 RVA: 0x002176EC File Offset: 0x002158EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 237335, RefRangeEnd = 237337, XrefRangeStart = 237300, XrefRangeEnd = 237335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLiquid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.NativeMethodInfoPtr_UpdateLiquid_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CA3 RID: 31907 RVA: 0x00217720 File Offset: 0x00215920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237337, XrefRangeEnd = 237351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetLiquidVolume(string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.NativeMethodInfoPtr_GetLiquidVolume_Public_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007CA4 RID: 31908 RVA: 0x00217770 File Offset: 0x00215970
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 237369, RefRangeEnd = 237370, XrefRangeStart = 237351, XrefRangeEnd = 237369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetTotalLiquidVolume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.NativeMethodInfoPtr_GetTotalLiquidVolume_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007CA5 RID: 31909 RVA: 0x002177AC File Offset: 0x002159AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237370, XrefRangeEnd = 237378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Fillable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Fillable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CA6 RID: 31910 RVA: 0x0003B28B File Offset: 0x0003948B
		public Fillable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170025B0 RID: 9648
		// (get) Token: 0x06007CA7 RID: 31911 RVA: 0x002177E8 File Offset: 0x002159E8
		// (set) Token: 0x06007CA8 RID: 31912 RVA: 0x0003B294 File Offset: 0x00039494
		public unsafe List<Fillable.Content> _contents_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.NativeFieldInfoPtr__contents_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Fillable.Content>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.NativeFieldInfoPtr__contents_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025B1 RID: 9649
		// (get) Token: 0x06007CA9 RID: 31913 RVA: 0x00217818 File Offset: 0x00215A18
		// (set) Token: 0x06007CAA RID: 31914 RVA: 0x0003B2B3 File Offset: 0x000394B3
		public unsafe LiquidContainer LiquidContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.NativeFieldInfoPtr_LiquidContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.NativeFieldInfoPtr_LiquidContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025B2 RID: 9650
		// (get) Token: 0x06007CAB RID: 31915 RVA: 0x00217848 File Offset: 0x00215A48
		// (set) Token: 0x06007CAC RID: 31916 RVA: 0x0003B2D2 File Offset: 0x000394D2
		public unsafe bool FillableEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.NativeFieldInfoPtr_FillableEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.NativeFieldInfoPtr_FillableEnabled)) = value;
			}
		}

		// Token: 0x170025B3 RID: 9651
		// (get) Token: 0x06007CAD RID: 31917 RVA: 0x00217870 File Offset: 0x00215A70
		// (set) Token: 0x06007CAE RID: 31918 RVA: 0x0003B2ED File Offset: 0x000394ED
		public unsafe float LiquidCapacity_L
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.NativeFieldInfoPtr_LiquidCapacity_L);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.NativeFieldInfoPtr_LiquidCapacity_L)) = value;
			}
		}

		// Token: 0x040054D3 RID: 21715
		private static readonly IntPtr NativeFieldInfoPtr__contents_k__BackingField;

		// Token: 0x040054D4 RID: 21716
		private static readonly IntPtr NativeFieldInfoPtr_LiquidContainer;

		// Token: 0x040054D5 RID: 21717
		private static readonly IntPtr NativeFieldInfoPtr_FillableEnabled;

		// Token: 0x040054D6 RID: 21718
		private static readonly IntPtr NativeFieldInfoPtr_LiquidCapacity_L;

		// Token: 0x040054D7 RID: 21719
		private static readonly IntPtr NativeMethodInfoPtr_get_contents_Public_get_List_1_Content_0;

		// Token: 0x040054D8 RID: 21720
		private static readonly IntPtr NativeMethodInfoPtr_set_contents_Protected_set_Void_List_1_Content_0;

		// Token: 0x040054D9 RID: 21721
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040054DA RID: 21722
		private static readonly IntPtr NativeMethodInfoPtr_AddLiquid_Public_Void_String_Single_Color_0;

		// Token: 0x040054DB RID: 21723
		private static readonly IntPtr NativeMethodInfoPtr_ResetContents_Public_Void_0;

		// Token: 0x040054DC RID: 21724
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLiquid_Private_Void_0;

		// Token: 0x040054DD RID: 21725
		private static readonly IntPtr NativeMethodInfoPtr_GetLiquidVolume_Public_Single_String_0;

		// Token: 0x040054DE RID: 21726
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalLiquidVolume_Public_Single_0;

		// Token: 0x040054DF RID: 21727
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AB5 RID: 2741
		public class Content : Il2CppSystem.Object
		{
			// Token: 0x0600D3AB RID: 54187 RVA: 0x00328D24 File Offset: 0x00326F24
			// Note: this type is marked as 'beforefieldinit'.
			static Content()
			{
				Il2CppClassPointerStore<Fillable.Content>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Fillable>.NativeClassPtr, "Content");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Fillable.Content>.NativeClassPtr);
				Fillable.Content.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable.Content>.NativeClassPtr, "Label");
				Fillable.Content.NativeFieldInfoPtr_Volume_L = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable.Content>.NativeClassPtr, "Volume_L");
				Fillable.Content.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable.Content>.NativeClassPtr, "Color");
				Fillable.Content.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable.Content>.NativeClassPtr, 100678908);
			}

			// Token: 0x0600D3AC RID: 54188 RVA: 0x00328DA0 File Offset: 0x00326FA0
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Content() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Fillable.Content>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.Content.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3AD RID: 54189 RVA: 0x000670C6 File Offset: 0x000652C6
			public Content(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041A4 RID: 16804
			// (get) Token: 0x0600D3AE RID: 54190 RVA: 0x00328DDC File Offset: 0x00326FDC
			// (set) Token: 0x0600D3AF RID: 54191 RVA: 0x000670CF File Offset: 0x000652CF
			public unsafe string Label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.Content.NativeFieldInfoPtr_Label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.Content.NativeFieldInfoPtr_Label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170041A5 RID: 16805
			// (get) Token: 0x0600D3B0 RID: 54192 RVA: 0x00328E04 File Offset: 0x00327004
			// (set) Token: 0x0600D3B1 RID: 54193 RVA: 0x000670EE File Offset: 0x000652EE
			public unsafe float Volume_L
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.Content.NativeFieldInfoPtr_Volume_L);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.Content.NativeFieldInfoPtr_Volume_L)) = value;
				}
			}

			// Token: 0x170041A6 RID: 16806
			// (get) Token: 0x0600D3B2 RID: 54194 RVA: 0x00328E2C File Offset: 0x0032702C
			// (set) Token: 0x0600D3B3 RID: 54195 RVA: 0x00067109 File Offset: 0x00065309
			public unsafe Color Color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.Content.NativeFieldInfoPtr_Color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.Content.NativeFieldInfoPtr_Color)) = value;
				}
			}

			// Token: 0x04008E95 RID: 36501
			private static readonly IntPtr NativeFieldInfoPtr_Label;

			// Token: 0x04008E96 RID: 36502
			private static readonly IntPtr NativeFieldInfoPtr_Volume_L;

			// Token: 0x04008E97 RID: 36503
			private static readonly IntPtr NativeFieldInfoPtr_Color;

			// Token: 0x04008E98 RID: 36504
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AB6 RID: 2742
		[ObfuscatedName("ScheduleOne.StationFramework.Fillable+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D3B4 RID: 54196 RVA: 0x00328E54 File Offset: 0x00327054
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Fillable.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Fillable>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Fillable.__c>.NativeClassPtr);
				Fillable.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable.__c>.NativeClassPtr, "<>9");
				Fillable.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable.__c>.NativeClassPtr, "<>9__11_0");
				Fillable.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable.__c>.NativeClassPtr, "<>9__13_0");
				Fillable.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable.__c>.NativeClassPtr, 100678910);
				Fillable.__c.NativeMethodInfoPtr__UpdateLiquid_b__11_0_Internal_Single_Content_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable.__c>.NativeClassPtr, 100678911);
				Fillable.__c.NativeMethodInfoPtr__GetTotalLiquidVolume_b__13_0_Internal_Single_Content_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable.__c>.NativeClassPtr, 100678912);
			}

			// Token: 0x0600D3B5 RID: 54197 RVA: 0x00328EF8 File Offset: 0x003270F8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Fillable.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3B6 RID: 54198 RVA: 0x00328F34 File Offset: 0x00327134
			[CallerCount(0)]
			public unsafe float _UpdateLiquid_b__11_0(Fillable.Content x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.__c.NativeMethodInfoPtr__UpdateLiquid_b__11_0_Internal_Single_Content_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D3B7 RID: 54199 RVA: 0x00328F84 File Offset: 0x00327184
			[CallerCount(0)]
			public unsafe float _GetTotalLiquidVolume_b__13_0(Fillable.Content x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.__c.NativeMethodInfoPtr__GetTotalLiquidVolume_b__13_0_Internal_Single_Content_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D3B8 RID: 54200 RVA: 0x00067124 File Offset: 0x00065324
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041A7 RID: 16807
			// (get) Token: 0x0600D3B9 RID: 54201 RVA: 0x00328FD4 File Offset: 0x003271D4
			// (set) Token: 0x0600D3BA RID: 54202 RVA: 0x0006712D File Offset: 0x0006532D
			public unsafe static Fillable.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Fillable.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Fillable.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Fillable.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041A8 RID: 16808
			// (get) Token: 0x0600D3BB RID: 54203 RVA: 0x00328FFC File Offset: 0x003271FC
			// (set) Token: 0x0600D3BC RID: 54204 RVA: 0x0006713F File Offset: 0x0006533F
			public unsafe static Func<Fillable.Content, float> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Fillable.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Fillable.Content, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Fillable.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041A9 RID: 16809
			// (get) Token: 0x0600D3BD RID: 54205 RVA: 0x00329024 File Offset: 0x00327224
			// (set) Token: 0x0600D3BE RID: 54206 RVA: 0x00067151 File Offset: 0x00065351
			public unsafe static Func<Fillable.Content, float> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Fillable.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Fillable.Content, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Fillable.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E99 RID: 36505
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008E9A RID: 36506
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x04008E9B RID: 36507
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x04008E9C RID: 36508
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E9D RID: 36509
			private static readonly IntPtr NativeMethodInfoPtr__UpdateLiquid_b__11_0_Internal_Single_Content_0;

			// Token: 0x04008E9E RID: 36510
			private static readonly IntPtr NativeMethodInfoPtr__GetTotalLiquidVolume_b__13_0_Internal_Single_Content_0;
		}

		// Token: 0x02000AB7 RID: 2743
		[ObfuscatedName("ScheduleOne.StationFramework.Fillable+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D3BF RID: 54207 RVA: 0x0032904C File Offset: 0x0032724C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<Fillable.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Fillable>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Fillable.__c__DisplayClass11_0>.NativeClassPtr);
				Fillable.__c__DisplayClass11_0.NativeFieldInfoPtr_totalVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable.__c__DisplayClass11_0>.NativeClassPtr, "totalVolume");
				Fillable.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable.__c__DisplayClass11_0>.NativeClassPtr, 100678913);
				Fillable.__c__DisplayClass11_0.NativeMethodInfoPtr__UpdateLiquid_b__1_Internal_Color_Color_Content_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable.__c__DisplayClass11_0>.NativeClassPtr, 100678914);
			}

			// Token: 0x0600D3C0 RID: 54208 RVA: 0x003290B4 File Offset: 0x003272B4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Fillable.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3C1 RID: 54209 RVA: 0x003290F0 File Offset: 0x003272F0
			[CallerCount(0)]
			public unsafe Color _UpdateLiquid_b__1(Color acc, Fillable.Content c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref acc;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.__c__DisplayClass11_0.NativeMethodInfoPtr__UpdateLiquid_b__1_Internal_Color_Color_Content_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D3C2 RID: 54210 RVA: 0x00067163 File Offset: 0x00065363
			public __c__DisplayClass11_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041AA RID: 16810
			// (get) Token: 0x0600D3C3 RID: 54211 RVA: 0x0032914C File Offset: 0x0032734C
			// (set) Token: 0x0600D3C4 RID: 54212 RVA: 0x0006716C File Offset: 0x0006536C
			public unsafe float totalVolume
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.__c__DisplayClass11_0.NativeFieldInfoPtr_totalVolume);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.__c__DisplayClass11_0.NativeFieldInfoPtr_totalVolume)) = value;
				}
			}

			// Token: 0x04008E9F RID: 36511
			private static readonly IntPtr NativeFieldInfoPtr_totalVolume;

			// Token: 0x04008EA0 RID: 36512
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EA1 RID: 36513
			private static readonly IntPtr NativeMethodInfoPtr__UpdateLiquid_b__1_Internal_Color_Color_Content_0;
		}

		// Token: 0x02000AB8 RID: 2744
		[ObfuscatedName("ScheduleOne.StationFramework.Fillable+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D3C5 RID: 54213 RVA: 0x00329174 File Offset: 0x00327374
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<Fillable.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Fillable>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Fillable.__c__DisplayClass12_0>.NativeClassPtr);
				Fillable.__c__DisplayClass12_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable.__c__DisplayClass12_0>.NativeClassPtr, "label");
				Fillable.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable.__c__DisplayClass12_0>.NativeClassPtr, 100678915);
				Fillable.__c__DisplayClass12_0.NativeMethodInfoPtr__GetLiquidVolume_b__0_Internal_Boolean_Content_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable.__c__DisplayClass12_0>.NativeClassPtr, 100678916);
			}

			// Token: 0x0600D3C6 RID: 54214 RVA: 0x003291DC File Offset: 0x003273DC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Fillable.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3C7 RID: 54215 RVA: 0x00329218 File Offset: 0x00327418
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetLiquidVolume_b__0(Fillable.Content c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.__c__DisplayClass12_0.NativeMethodInfoPtr__GetLiquidVolume_b__0_Internal_Boolean_Content_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D3C8 RID: 54216 RVA: 0x00067187 File Offset: 0x00065387
			public __c__DisplayClass12_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041AB RID: 16811
			// (get) Token: 0x0600D3C9 RID: 54217 RVA: 0x00329268 File Offset: 0x00327468
			// (set) Token: 0x0600D3CA RID: 54218 RVA: 0x00067190 File Offset: 0x00065390
			public unsafe string label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.__c__DisplayClass12_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.__c__DisplayClass12_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008EA2 RID: 36514
			private static readonly IntPtr NativeFieldInfoPtr_label;

			// Token: 0x04008EA3 RID: 36515
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EA4 RID: 36516
			private static readonly IntPtr NativeMethodInfoPtr__GetLiquidVolume_b__0_Internal_Boolean_Content_0;
		}

		// Token: 0x02000AB9 RID: 2745
		[ObfuscatedName("ScheduleOne.StationFramework.Fillable+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D3CB RID: 54219 RVA: 0x00329290 File Offset: 0x00327490
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<Fillable.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Fillable>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Fillable.__c__DisplayClass9_0>.NativeClassPtr);
				Fillable.__c__DisplayClass9_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable.__c__DisplayClass9_0>.NativeClassPtr, "label");
				Fillable.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable.__c__DisplayClass9_0>.NativeClassPtr, 100678917);
				Fillable.__c__DisplayClass9_0.NativeMethodInfoPtr__AddLiquid_b__0_Internal_Boolean_Content_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable.__c__DisplayClass9_0>.NativeClassPtr, 100678918);
			}

			// Token: 0x0600D3CC RID: 54220 RVA: 0x003292F8 File Offset: 0x003274F8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Fillable.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3CD RID: 54221 RVA: 0x00329334 File Offset: 0x00327534
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddLiquid_b__0(Fillable.Content c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.__c__DisplayClass9_0.NativeMethodInfoPtr__AddLiquid_b__0_Internal_Boolean_Content_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D3CE RID: 54222 RVA: 0x000671AF File Offset: 0x000653AF
			public __c__DisplayClass9_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041AC RID: 16812
			// (get) Token: 0x0600D3CF RID: 54223 RVA: 0x00329384 File Offset: 0x00327584
			// (set) Token: 0x0600D3D0 RID: 54224 RVA: 0x000671B8 File Offset: 0x000653B8
			public unsafe string label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.__c__DisplayClass9_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.__c__DisplayClass9_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008EA5 RID: 36517
			private static readonly IntPtr NativeFieldInfoPtr_label;

			// Token: 0x04008EA6 RID: 36518
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EA7 RID: 36519
			private static readonly IntPtr NativeMethodInfoPtr__AddLiquid_b__0_Internal_Boolean_Content_0;
		}
	}
}
