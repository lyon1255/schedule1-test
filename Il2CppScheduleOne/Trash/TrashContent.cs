using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Trash
{
	// Token: 0x02000520 RID: 1312
	[Serializable]
	public class TrashContent : Object
	{
		// Token: 0x060074D2 RID: 29906 RVA: 0x001FCEFC File Offset: 0x001FB0FC
		// Note: this type is marked as 'beforefieldinit'.
		static TrashContent()
		{
			Il2CppClassPointerStore<TrashContent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Trash", "TrashContent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashContent>.NativeClassPtr);
			TrashContent.NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, "Entries");
			TrashContent.NativeMethodInfoPtr_AddTrash_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, 100677982);
			TrashContent.NativeMethodInfoPtr_RemoveTrash_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, 100677983);
			TrashContent.NativeMethodInfoPtr_GetTrashQuantity_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, 100677984);
			TrashContent.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, 100677985);
			TrashContent.NativeMethodInfoPtr_GetTotalSize_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, 100677986);
			TrashContent.NativeMethodInfoPtr_GetData_Public_TrashContentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, 100677987);
			TrashContent.NativeMethodInfoPtr_LoadFromData_Public_Void_TrashContentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, 100677988);
			TrashContent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, 100677989);
		}

		// Token: 0x060074D3 RID: 29907 RVA: 0x001FCFE0 File Offset: 0x001FB1E0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 228124, RefRangeEnd = 228130, XrefRangeStart = 228086, XrefRangeEnd = 228124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTrash(string trashID, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trashID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.NativeMethodInfoPtr_AddTrash_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074D4 RID: 29908 RVA: 0x001FD030 File Offset: 0x001FB230
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 228147, RefRangeEnd = 228148, XrefRangeStart = 228130, XrefRangeEnd = 228147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveTrash(string trashID, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trashID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.NativeMethodInfoPtr_RemoveTrash_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074D5 RID: 29909 RVA: 0x001FD080 File Offset: 0x001FB280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228148, XrefRangeEnd = 228162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTrashQuantity(string trashID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trashID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.NativeMethodInfoPtr_GetTrashQuantity_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060074D6 RID: 29910 RVA: 0x001FD0D0 File Offset: 0x001FB2D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 228164, RefRangeEnd = 228165, XrefRangeStart = 228162, XrefRangeEnd = 228164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074D7 RID: 29911 RVA: 0x001FD104 File Offset: 0x001FB304
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 228179, RefRangeEnd = 228190, XrefRangeStart = 228165, XrefRangeEnd = 228179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTotalSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.NativeMethodInfoPtr_GetTotalSize_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060074D8 RID: 29912 RVA: 0x001FD140 File Offset: 0x001FB340
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 228210, RefRangeEnd = 228217, XrefRangeStart = 228190, XrefRangeEnd = 228210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashContentData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.NativeMethodInfoPtr_GetData_Public_TrashContentData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrashContentData>(intPtr3) : null;
		}

		// Token: 0x060074D9 RID: 29913 RVA: 0x001FD180 File Offset: 0x001FB380
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 228219, RefRangeEnd = 228222, XrefRangeStart = 228217, XrefRangeEnd = 228219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadFromData(TrashContentData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.NativeMethodInfoPtr_LoadFromData_Public_Void_TrashContentData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074DA RID: 29914 RVA: 0x001FD1C4 File Offset: 0x001FB3C4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 228230, RefRangeEnd = 228234, XrefRangeStart = 228222, XrefRangeEnd = 228230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashContent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074DB RID: 29915 RVA: 0x00037720 File Offset: 0x00035920
		public TrashContent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002363 RID: 9059
		// (get) Token: 0x060074DC RID: 29916 RVA: 0x001FD200 File Offset: 0x001FB400
		// (set) Token: 0x060074DD RID: 29917 RVA: 0x00037729 File Offset: 0x00035929
		public unsafe List<TrashContent.Entry> Entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.NativeFieldInfoPtr_Entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TrashContent.Entry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.NativeFieldInfoPtr_Entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004FC6 RID: 20422
		private static readonly IntPtr NativeFieldInfoPtr_Entries;

		// Token: 0x04004FC7 RID: 20423
		private static readonly IntPtr NativeMethodInfoPtr_AddTrash_Public_Void_String_Int32_0;

		// Token: 0x04004FC8 RID: 20424
		private static readonly IntPtr NativeMethodInfoPtr_RemoveTrash_Public_Void_String_Int32_0;

		// Token: 0x04004FC9 RID: 20425
		private static readonly IntPtr NativeMethodInfoPtr_GetTrashQuantity_Public_Int32_String_0;

		// Token: 0x04004FCA RID: 20426
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04004FCB RID: 20427
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalSize_Public_Int32_0;

		// Token: 0x04004FCC RID: 20428
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_TrashContentData_0;

		// Token: 0x04004FCD RID: 20429
		private static readonly IntPtr NativeMethodInfoPtr_LoadFromData_Public_Void_TrashContentData_0;

		// Token: 0x04004FCE RID: 20430
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A8D RID: 2701
		[Serializable]
		public class Entry : Object
		{
			// Token: 0x0600D263 RID: 53859 RVA: 0x00325474 File Offset: 0x00323674
			// Note: this type is marked as 'beforefieldinit'.
			static Entry()
			{
				Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, "Entry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr);
				TrashContent.Entry.NativeFieldInfoPtr_TrashID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr, "TrashID");
				TrashContent.Entry.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr, "Quantity");
				TrashContent.Entry.NativeFieldInfoPtr__UnitSize_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr, "<UnitSize>k__BackingField");
				TrashContent.Entry.NativeFieldInfoPtr__UnitValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr, "<UnitValue>k__BackingField");
				TrashContent.Entry.NativeMethodInfoPtr_get_UnitSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr, 100677990);
				TrashContent.Entry.NativeMethodInfoPtr_set_UnitSize_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr, 100677991);
				TrashContent.Entry.NativeMethodInfoPtr_get_UnitValue_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr, 100677992);
				TrashContent.Entry.NativeMethodInfoPtr_set_UnitValue_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr, 100677993);
				TrashContent.Entry.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr, 100677994);
			}

			// Token: 0x1700414B RID: 16715
			// (get) Token: 0x0600D264 RID: 53860 RVA: 0x00325554 File Offset: 0x00323754
			// (set) Token: 0x0600D265 RID: 53861 RVA: 0x00325590 File Offset: 0x00323790
			public unsafe int UnitSize
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.Entry.NativeMethodInfoPtr_get_UnitSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 41635, RefRangeEnd = 41636, XrefRangeStart = 41635, XrefRangeEnd = 41636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.Entry.NativeMethodInfoPtr_set_UnitSize_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x1700414C RID: 16716
			// (get) Token: 0x0600D266 RID: 53862 RVA: 0x003255D0 File Offset: 0x003237D0
			// (set) Token: 0x0600D267 RID: 53863 RVA: 0x0032560C File Offset: 0x0032380C
			public unsafe int UnitValue
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 20566, RefRangeEnd = 20567, XrefRangeStart = 20566, XrefRangeEnd = 20567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.Entry.NativeMethodInfoPtr_get_UnitValue_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 29975, RefRangeEnd = 29976, XrefRangeStart = 29975, XrefRangeEnd = 29976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.Entry.NativeMethodInfoPtr_set_UnitValue_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600D268 RID: 53864 RVA: 0x0032564C File Offset: 0x0032384C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228075, XrefRangeEnd = 228086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entry(string id, int quantity) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.Entry.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D269 RID: 53865 RVA: 0x000666AE File Offset: 0x000648AE
			public Entry(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004147 RID: 16711
			// (get) Token: 0x0600D26A RID: 53866 RVA: 0x003256A8 File Offset: 0x003238A8
			// (set) Token: 0x0600D26B RID: 53867 RVA: 0x000666B7 File Offset: 0x000648B7
			public unsafe string TrashID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.Entry.NativeFieldInfoPtr_TrashID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.Entry.NativeFieldInfoPtr_TrashID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004148 RID: 16712
			// (get) Token: 0x0600D26C RID: 53868 RVA: 0x003256D0 File Offset: 0x003238D0
			// (set) Token: 0x0600D26D RID: 53869 RVA: 0x000666D6 File Offset: 0x000648D6
			public unsafe int Quantity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.Entry.NativeFieldInfoPtr_Quantity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.Entry.NativeFieldInfoPtr_Quantity)) = value;
				}
			}

			// Token: 0x17004149 RID: 16713
			// (get) Token: 0x0600D26E RID: 53870 RVA: 0x003256F8 File Offset: 0x003238F8
			// (set) Token: 0x0600D26F RID: 53871 RVA: 0x000666F1 File Offset: 0x000648F1
			public unsafe int _UnitSize_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.Entry.NativeFieldInfoPtr__UnitSize_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.Entry.NativeFieldInfoPtr__UnitSize_k__BackingField)) = value;
				}
			}

			// Token: 0x1700414A RID: 16714
			// (get) Token: 0x0600D270 RID: 53872 RVA: 0x00325720 File Offset: 0x00323920
			// (set) Token: 0x0600D271 RID: 53873 RVA: 0x0006670C File Offset: 0x0006490C
			public unsafe int _UnitValue_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.Entry.NativeFieldInfoPtr__UnitValue_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.Entry.NativeFieldInfoPtr__UnitValue_k__BackingField)) = value;
				}
			}

			// Token: 0x04008DE0 RID: 36320
			private static readonly IntPtr NativeFieldInfoPtr_TrashID;

			// Token: 0x04008DE1 RID: 36321
			private static readonly IntPtr NativeFieldInfoPtr_Quantity;

			// Token: 0x04008DE2 RID: 36322
			private static readonly IntPtr NativeFieldInfoPtr__UnitSize_k__BackingField;

			// Token: 0x04008DE3 RID: 36323
			private static readonly IntPtr NativeFieldInfoPtr__UnitValue_k__BackingField;

			// Token: 0x04008DE4 RID: 36324
			private static readonly IntPtr NativeMethodInfoPtr_get_UnitSize_Public_get_Int32_0;

			// Token: 0x04008DE5 RID: 36325
			private static readonly IntPtr NativeMethodInfoPtr_set_UnitSize_Private_set_Void_Int32_0;

			// Token: 0x04008DE6 RID: 36326
			private static readonly IntPtr NativeMethodInfoPtr_get_UnitValue_Public_get_Int32_0;

			// Token: 0x04008DE7 RID: 36327
			private static readonly IntPtr NativeMethodInfoPtr_set_UnitValue_Private_set_Void_Int32_0;

			// Token: 0x04008DE8 RID: 36328
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;
		}

		// Token: 0x02000A8E RID: 2702
		[ObfuscatedName("ScheduleOne.Trash.TrashContent+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x0600D272 RID: 53874 RVA: 0x00325748 File Offset: 0x00323948
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<TrashContent.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashContent.__c__DisplayClass2_0>.NativeClassPtr);
				TrashContent.__c__DisplayClass2_0.NativeFieldInfoPtr_trashID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContent.__c__DisplayClass2_0>.NativeClassPtr, "trashID");
				TrashContent.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent.__c__DisplayClass2_0>.NativeClassPtr, 100677995);
				TrashContent.__c__DisplayClass2_0.NativeMethodInfoPtr__AddTrash_b__0_Internal_Boolean_Entry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent.__c__DisplayClass2_0>.NativeClassPtr, 100677996);
			}

			// Token: 0x0600D273 RID: 53875 RVA: 0x003257B0 File Offset: 0x003239B0
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContent.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D274 RID: 53876 RVA: 0x003257EC File Offset: 0x003239EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddTrash_b__0(TrashContent.Entry e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.__c__DisplayClass2_0.NativeMethodInfoPtr__AddTrash_b__0_Internal_Boolean_Entry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D275 RID: 53877 RVA: 0x00066727 File Offset: 0x00064927
			public __c__DisplayClass2_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700414D RID: 16717
			// (get) Token: 0x0600D276 RID: 53878 RVA: 0x0032583C File Offset: 0x00323A3C
			// (set) Token: 0x0600D277 RID: 53879 RVA: 0x00066730 File Offset: 0x00064930
			public unsafe string trashID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.__c__DisplayClass2_0.NativeFieldInfoPtr_trashID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.__c__DisplayClass2_0.NativeFieldInfoPtr_trashID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008DE9 RID: 36329
			private static readonly IntPtr NativeFieldInfoPtr_trashID;

			// Token: 0x04008DEA RID: 36330
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008DEB RID: 36331
			private static readonly IntPtr NativeMethodInfoPtr__AddTrash_b__0_Internal_Boolean_Entry_0;
		}

		// Token: 0x02000A8F RID: 2703
		[ObfuscatedName("ScheduleOne.Trash.TrashContent+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x0600D278 RID: 53880 RVA: 0x00325864 File Offset: 0x00323A64
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<TrashContent.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashContent.__c__DisplayClass3_0>.NativeClassPtr);
				TrashContent.__c__DisplayClass3_0.NativeFieldInfoPtr_trashID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContent.__c__DisplayClass3_0>.NativeClassPtr, "trashID");
				TrashContent.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent.__c__DisplayClass3_0>.NativeClassPtr, 100677997);
				TrashContent.__c__DisplayClass3_0.NativeMethodInfoPtr__RemoveTrash_b__0_Internal_Boolean_Entry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent.__c__DisplayClass3_0>.NativeClassPtr, 100677998);
			}

			// Token: 0x0600D279 RID: 53881 RVA: 0x003258CC File Offset: 0x00323ACC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContent.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D27A RID: 53882 RVA: 0x00325908 File Offset: 0x00323B08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveTrash_b__0(TrashContent.Entry e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.__c__DisplayClass3_0.NativeMethodInfoPtr__RemoveTrash_b__0_Internal_Boolean_Entry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D27B RID: 53883 RVA: 0x0006674F File Offset: 0x0006494F
			public __c__DisplayClass3_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700414E RID: 16718
			// (get) Token: 0x0600D27C RID: 53884 RVA: 0x00325958 File Offset: 0x00323B58
			// (set) Token: 0x0600D27D RID: 53885 RVA: 0x00066758 File Offset: 0x00064958
			public unsafe string trashID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.__c__DisplayClass3_0.NativeFieldInfoPtr_trashID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.__c__DisplayClass3_0.NativeFieldInfoPtr_trashID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008DEC RID: 36332
			private static readonly IntPtr NativeFieldInfoPtr_trashID;

			// Token: 0x04008DED RID: 36333
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008DEE RID: 36334
			private static readonly IntPtr NativeMethodInfoPtr__RemoveTrash_b__0_Internal_Boolean_Entry_0;
		}

		// Token: 0x02000A90 RID: 2704
		[ObfuscatedName("ScheduleOne.Trash.TrashContent+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x0600D27E RID: 53886 RVA: 0x00325980 File Offset: 0x00323B80
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<TrashContent.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashContent.__c__DisplayClass4_0>.NativeClassPtr);
				TrashContent.__c__DisplayClass4_0.NativeFieldInfoPtr_trashID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContent.__c__DisplayClass4_0>.NativeClassPtr, "trashID");
				TrashContent.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent.__c__DisplayClass4_0>.NativeClassPtr, 100677999);
				TrashContent.__c__DisplayClass4_0.NativeMethodInfoPtr__GetTrashQuantity_b__0_Internal_Boolean_Entry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent.__c__DisplayClass4_0>.NativeClassPtr, 100678000);
			}

			// Token: 0x0600D27F RID: 53887 RVA: 0x003259E8 File Offset: 0x00323BE8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContent.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D280 RID: 53888 RVA: 0x00325A24 File Offset: 0x00323C24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetTrashQuantity_b__0(TrashContent.Entry e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.__c__DisplayClass4_0.NativeMethodInfoPtr__GetTrashQuantity_b__0_Internal_Boolean_Entry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D281 RID: 53889 RVA: 0x00066777 File Offset: 0x00064977
			public __c__DisplayClass4_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700414F RID: 16719
			// (get) Token: 0x0600D282 RID: 53890 RVA: 0x00325A74 File Offset: 0x00323C74
			// (set) Token: 0x0600D283 RID: 53891 RVA: 0x00066780 File Offset: 0x00064980
			public unsafe string trashID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.__c__DisplayClass4_0.NativeFieldInfoPtr_trashID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.__c__DisplayClass4_0.NativeFieldInfoPtr_trashID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008DEF RID: 36335
			private static readonly IntPtr NativeFieldInfoPtr_trashID;

			// Token: 0x04008DF0 RID: 36336
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008DF1 RID: 36337
			private static readonly IntPtr NativeMethodInfoPtr__GetTrashQuantity_b__0_Internal_Boolean_Entry_0;
		}
	}
}
