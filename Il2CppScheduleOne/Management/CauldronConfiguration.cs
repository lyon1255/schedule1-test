using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x02000384 RID: 900
	public class CauldronConfiguration : EntityConfiguration
	{
		// Token: 0x06004689 RID: 18057 RVA: 0x0015ACB8 File Offset: 0x00158EB8
		// Note: this type is marked as 'beforefieldinit'.
		static CauldronConfiguration()
		{
			Il2CppClassPointerStore<CauldronConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "CauldronConfiguration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CauldronConfiguration>.NativeClassPtr);
			CauldronConfiguration.NativeFieldInfoPtr__Station_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronConfiguration>.NativeClassPtr, "<Station>k__BackingField");
			CauldronConfiguration.NativeFieldInfoPtr_AssignedChemist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronConfiguration>.NativeClassPtr, "AssignedChemist");
			CauldronConfiguration.NativeFieldInfoPtr_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronConfiguration>.NativeClassPtr, "Destination");
			CauldronConfiguration.NativeFieldInfoPtr__DestinationRoute_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronConfiguration>.NativeClassPtr, "<DestinationRoute>k__BackingField");
			CauldronConfiguration.NativeMethodInfoPtr_get_Station_Public_get_Cauldron_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronConfiguration>.NativeClassPtr, 100672005);
			CauldronConfiguration.NativeMethodInfoPtr_set_Station_Protected_set_Void_Cauldron_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronConfiguration>.NativeClassPtr, 100672006);
			CauldronConfiguration.NativeMethodInfoPtr_get_DestinationRoute_Public_get_TransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronConfiguration>.NativeClassPtr, 100672007);
			CauldronConfiguration.NativeMethodInfoPtr_set_DestinationRoute_Protected_set_Void_TransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronConfiguration>.NativeClassPtr, 100672008);
			CauldronConfiguration.NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_Cauldron_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronConfiguration>.NativeClassPtr, 100672009);
			CauldronConfiguration.NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronConfiguration>.NativeClassPtr, 100672010);
			CauldronConfiguration.NativeMethodInfoPtr_DestinationChanged_Private_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronConfiguration>.NativeClassPtr, 100672011);
			CauldronConfiguration.NativeMethodInfoPtr_DestinationFilter_Public_Boolean_BuildableItem_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronConfiguration>.NativeClassPtr, 100672012);
			CauldronConfiguration.NativeMethodInfoPtr_Selected_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronConfiguration>.NativeClassPtr, 100672013);
			CauldronConfiguration.NativeMethodInfoPtr_Deselected_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronConfiguration>.NativeClassPtr, 100672014);
			CauldronConfiguration.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronConfiguration>.NativeClassPtr, 100672015);
			CauldronConfiguration.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronConfiguration>.NativeClassPtr, 100672016);
			CauldronConfiguration.NativeMethodInfoPtr___ctor_b__10_0_Private_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronConfiguration>.NativeClassPtr, 100672017);
			CauldronConfiguration.NativeMethodInfoPtr___ctor_b__10_1_Private_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronConfiguration>.NativeClassPtr, 100672018);
		}

		// Token: 0x17001532 RID: 5426
		// (get) Token: 0x0600468A RID: 18058 RVA: 0x0015AE50 File Offset: 0x00159050
		// (set) Token: 0x0600468B RID: 18059 RVA: 0x0015AE90 File Offset: 0x00159090
		public unsafe Cauldron Station
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 19662, RefRangeEnd = 19669, XrefRangeStart = 19662, XrefRangeEnd = 19669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronConfiguration.NativeMethodInfoPtr_get_Station_Public_get_Cauldron_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Cauldron>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronConfiguration.NativeMethodInfoPtr_set_Station_Protected_set_Void_Cauldron_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001533 RID: 5427
		// (get) Token: 0x0600468C RID: 18060 RVA: 0x0015AED4 File Offset: 0x001590D4
		// (set) Token: 0x0600468D RID: 18061 RVA: 0x0015AF14 File Offset: 0x00159114
		public unsafe TransitRoute DestinationRoute
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 16596, RefRangeEnd = 16597, XrefRangeStart = 16596, XrefRangeEnd = 16597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronConfiguration.NativeMethodInfoPtr_get_DestinationRoute_Public_get_TransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TransitRoute>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 38372, RefRangeEnd = 38373, XrefRangeStart = 38372, XrefRangeEnd = 38373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronConfiguration.NativeMethodInfoPtr_set_DestinationRoute_Protected_set_Void_TransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600468E RID: 18062 RVA: 0x0015AF58 File Offset: 0x00159158
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 159429, RefRangeEnd = 159430, XrefRangeStart = 159378, XrefRangeEnd = 159429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CauldronConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, Cauldron cauldron) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CauldronConfiguration>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(replicator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(configurable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cauldron);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronConfiguration.NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_Cauldron_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600468F RID: 18063 RVA: 0x0015AFC8 File Offset: 0x001591C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CauldronConfiguration.NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004690 RID: 18064 RVA: 0x0015B004 File Offset: 0x00159204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159430, XrefRangeEnd = 159439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestinationChanged(BuildableItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronConfiguration.NativeMethodInfoPtr_DestinationChanged_Private_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004691 RID: 18065 RVA: 0x0015B048 File Offset: 0x00159248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159439, XrefRangeEnd = 159456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DestinationFilter(BuildableItem obj, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CauldronConfiguration.NativeMethodInfoPtr_DestinationFilter_Public_Boolean_BuildableItem_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06004692 RID: 18066 RVA: 0x0015B0B0 File Offset: 0x001592B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Selected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CauldronConfiguration.NativeMethodInfoPtr_Selected_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004693 RID: 18067 RVA: 0x0015B0EC File Offset: 0x001592EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Deselected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CauldronConfiguration.NativeMethodInfoPtr_Deselected_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004694 RID: 18068 RVA: 0x0015B128 File Offset: 0x00159328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159456, XrefRangeEnd = 159460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CauldronConfiguration.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004695 RID: 18069 RVA: 0x0015B170 File Offset: 0x00159370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159460, XrefRangeEnd = 159466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CauldronConfiguration.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004696 RID: 18070 RVA: 0x0015B1B4 File Offset: 0x001593B4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 141788, RefRangeEnd = 141792, XrefRangeStart = 141788, XrefRangeEnd = 141792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__10_0(NPC <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronConfiguration.NativeMethodInfoPtr___ctor_b__10_0_Private_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004697 RID: 18071 RVA: 0x0015B1F8 File Offset: 0x001593F8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 141788, RefRangeEnd = 141792, XrefRangeStart = 141788, XrefRangeEnd = 141792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__10_1(BuildableItem <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronConfiguration.NativeMethodInfoPtr___ctor_b__10_1_Private_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004698 RID: 18072 RVA: 0x0002236A File Offset: 0x0002056A
		public CauldronConfiguration(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700152E RID: 5422
		// (get) Token: 0x06004699 RID: 18073 RVA: 0x0015B23C File Offset: 0x0015943C
		// (set) Token: 0x0600469A RID: 18074 RVA: 0x00022373 File Offset: 0x00020573
		public unsafe Cauldron _Station_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronConfiguration.NativeFieldInfoPtr__Station_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cauldron>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronConfiguration.NativeFieldInfoPtr__Station_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700152F RID: 5423
		// (get) Token: 0x0600469B RID: 18075 RVA: 0x0015B26C File Offset: 0x0015946C
		// (set) Token: 0x0600469C RID: 18076 RVA: 0x00022392 File Offset: 0x00020592
		public unsafe NPCField AssignedChemist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronConfiguration.NativeFieldInfoPtr_AssignedChemist);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronConfiguration.NativeFieldInfoPtr_AssignedChemist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001530 RID: 5424
		// (get) Token: 0x0600469D RID: 18077 RVA: 0x0015B29C File Offset: 0x0015949C
		// (set) Token: 0x0600469E RID: 18078 RVA: 0x000223B1 File Offset: 0x000205B1
		public unsafe ObjectField Destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronConfiguration.NativeFieldInfoPtr_Destination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronConfiguration.NativeFieldInfoPtr_Destination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001531 RID: 5425
		// (get) Token: 0x0600469F RID: 18079 RVA: 0x0015B2CC File Offset: 0x001594CC
		// (set) Token: 0x060046A0 RID: 18080 RVA: 0x000223D0 File Offset: 0x000205D0
		public unsafe TransitRoute _DestinationRoute_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronConfiguration.NativeFieldInfoPtr__DestinationRoute_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TransitRoute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronConfiguration.NativeFieldInfoPtr__DestinationRoute_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002F6E RID: 12142
		private static readonly IntPtr NativeFieldInfoPtr__Station_k__BackingField;

		// Token: 0x04002F6F RID: 12143
		private static readonly IntPtr NativeFieldInfoPtr_AssignedChemist;

		// Token: 0x04002F70 RID: 12144
		private static readonly IntPtr NativeFieldInfoPtr_Destination;

		// Token: 0x04002F71 RID: 12145
		private static readonly IntPtr NativeFieldInfoPtr__DestinationRoute_k__BackingField;

		// Token: 0x04002F72 RID: 12146
		private static readonly IntPtr NativeMethodInfoPtr_get_Station_Public_get_Cauldron_0;

		// Token: 0x04002F73 RID: 12147
		private static readonly IntPtr NativeMethodInfoPtr_set_Station_Protected_set_Void_Cauldron_0;

		// Token: 0x04002F74 RID: 12148
		private static readonly IntPtr NativeMethodInfoPtr_get_DestinationRoute_Public_get_TransitRoute_0;

		// Token: 0x04002F75 RID: 12149
		private static readonly IntPtr NativeMethodInfoPtr_set_DestinationRoute_Protected_set_Void_TransitRoute_0;

		// Token: 0x04002F76 RID: 12150
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_Cauldron_0;

		// Token: 0x04002F77 RID: 12151
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0;

		// Token: 0x04002F78 RID: 12152
		private static readonly IntPtr NativeMethodInfoPtr_DestinationChanged_Private_Void_BuildableItem_0;

		// Token: 0x04002F79 RID: 12153
		private static readonly IntPtr NativeMethodInfoPtr_DestinationFilter_Public_Boolean_BuildableItem_byref_String_0;

		// Token: 0x04002F7A RID: 12154
		private static readonly IntPtr NativeMethodInfoPtr_Selected_Public_Virtual_Void_0;

		// Token: 0x04002F7B RID: 12155
		private static readonly IntPtr NativeMethodInfoPtr_Deselected_Public_Virtual_Void_0;

		// Token: 0x04002F7C RID: 12156
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0;

		// Token: 0x04002F7D RID: 12157
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x04002F7E RID: 12158
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__10_0_Private_Void_NPC_0;

		// Token: 0x04002F7F RID: 12159
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__10_1_Private_Void_BuildableItem_0;
	}
}
