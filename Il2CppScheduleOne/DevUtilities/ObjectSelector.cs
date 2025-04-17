using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ConstructableScripts;
using Il2CppScheduleOne.EntityFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200045E RID: 1118
	public class ObjectSelector : Singleton<ObjectSelector>
	{
		// Token: 0x06006108 RID: 24840 RVA: 0x001BB1B4 File Offset: 0x001B93B4
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectSelector()
		{
			Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "ObjectSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr);
			ObjectSelector.NativeFieldInfoPtr_detectionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "detectionRange");
			ObjectSelector.NativeFieldInfoPtr_detectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "detectionMask");
			ObjectSelector.NativeFieldInfoPtr__isSelecting_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "<isSelecting>k__BackingField");
			ObjectSelector.NativeFieldInfoPtr_allowedTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "allowedTypes");
			ObjectSelector.NativeFieldInfoPtr_selectedObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "selectedObjects");
			ObjectSelector.NativeFieldInfoPtr_selectedConstructables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "selectedConstructables");
			ObjectSelector.NativeFieldInfoPtr_onClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "onClose");
			ObjectSelector.NativeFieldInfoPtr_selectionLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "selectionLimit");
			ObjectSelector.NativeFieldInfoPtr_exitOnSelectionLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "exitOnSelectionLimit");
			ObjectSelector.NativeFieldInfoPtr_hoveredBuildable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "hoveredBuildable");
			ObjectSelector.NativeFieldInfoPtr_hoveredConstructable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "hoveredConstructable");
			ObjectSelector.NativeFieldInfoPtr_outlinedObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "outlinedObjects");
			ObjectSelector.NativeFieldInfoPtr_outlinedConstructables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "outlinedConstructables");
			ObjectSelector.NativeMethodInfoPtr_get_isSelecting_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100675640);
			ObjectSelector.NativeMethodInfoPtr_set_isSelecting_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100675641);
			ObjectSelector.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100675642);
			ObjectSelector.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100675643);
			ObjectSelector.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100675644);
			ObjectSelector.NativeMethodInfoPtr_GetHoveredBuildable_Private_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100675645);
			ObjectSelector.NativeMethodInfoPtr_GetHoveredConstructable_Private_Constructable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100675646);
			ObjectSelector.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100675647);
			ObjectSelector.NativeMethodInfoPtr_StartSelecting_Public_Void_String_List_1_Type_byref_List_1_BuildableItem_byref_List_1_Constructable_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100675648);
			ObjectSelector.NativeMethodInfoPtr_StopSelecting_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100675649);
			ObjectSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100675650);
		}

		// Token: 0x17001D3B RID: 7483
		// (get) Token: 0x06006109 RID: 24841 RVA: 0x001BB3C4 File Offset: 0x001B95C4
		// (set) Token: 0x0600610A RID: 24842 RVA: 0x001BB400 File Offset: 0x001B9600
		public unsafe bool isSelecting
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_get_isSelecting_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_set_isSelecting_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600610B RID: 24843 RVA: 0x001BB440 File Offset: 0x001B9640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200059, XrefRangeEnd = 200072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectSelector.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600610C RID: 24844 RVA: 0x001BB47C File Offset: 0x001B967C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200072, XrefRangeEnd = 200177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectSelector.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600610D RID: 24845 RVA: 0x001BB4B8 File Offset: 0x001B96B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200177, XrefRangeEnd = 200237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectSelector.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600610E RID: 24846 RVA: 0x001BB4F4 File Offset: 0x001B96F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200237, XrefRangeEnd = 200254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildableItem GetHoveredBuildable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_GetHoveredBuildable_Private_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BuildableItem>(intPtr3) : null;
		}

		// Token: 0x0600610F RID: 24847 RVA: 0x001BB534 File Offset: 0x001B9734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200254, XrefRangeEnd = 200271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Constructable GetHoveredConstructable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_GetHoveredConstructable_Private_Constructable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Constructable>(intPtr3) : null;
		}

		// Token: 0x06006110 RID: 24848 RVA: 0x001BB574 File Offset: 0x001B9774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200271, XrefRangeEnd = 200272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006111 RID: 24849 RVA: 0x001BB5B8 File Offset: 0x001B97B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200272, XrefRangeEnd = 200312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartSelecting(string selectionTitle, List<Type> _typeRestriction, ref List<BuildableItem> initialSelection_Objects, ref List<Constructable> initalSelection_Constructables, int _selectionLimit, bool _exitOnSelectionLimit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(selectionTitle);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_typeRestriction);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(initialSelection_Objects);
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(initalSelection_Constructables);
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _selectionLimit;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _exitOnSelectionLimit;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_StartSelecting_Public_Void_String_List_1_Type_byref_List_1_BuildableItem_byref_List_1_Constructable_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			initialSelection_Objects = ((intPtr5 == 0) ? null : new List<BuildableItem>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			initalSelection_Constructables = ((intPtr6 == 0) ? null : new List<Constructable>(intPtr6));
		}

		// Token: 0x06006112 RID: 24850 RVA: 0x001BB67C File Offset: 0x001B987C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 200339, RefRangeEnd = 200340, XrefRangeStart = 200312, XrefRangeEnd = 200339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopSelecting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_StopSelecting_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006113 RID: 24851 RVA: 0x001BB6B0 File Offset: 0x001B98B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200340, XrefRangeEnd = 200367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectSelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006114 RID: 24852 RVA: 0x0002DD5A File Offset: 0x0002BF5A
		public ObjectSelector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D2E RID: 7470
		// (get) Token: 0x06006115 RID: 24853 RVA: 0x001BB6EC File Offset: 0x001B98EC
		// (set) Token: 0x06006116 RID: 24854 RVA: 0x0002DD63 File Offset: 0x0002BF63
		public unsafe float detectionRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_detectionRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_detectionRange)) = value;
			}
		}

		// Token: 0x17001D2F RID: 7471
		// (get) Token: 0x06006117 RID: 24855 RVA: 0x001BB714 File Offset: 0x001B9914
		// (set) Token: 0x06006118 RID: 24856 RVA: 0x0002DD7E File Offset: 0x0002BF7E
		public unsafe LayerMask detectionMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_detectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_detectionMask)) = value;
			}
		}

		// Token: 0x17001D30 RID: 7472
		// (get) Token: 0x06006119 RID: 24857 RVA: 0x001BB73C File Offset: 0x001B993C
		// (set) Token: 0x0600611A RID: 24858 RVA: 0x0002DD99 File Offset: 0x0002BF99
		public unsafe bool _isSelecting_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr__isSelecting_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr__isSelecting_k__BackingField)) = value;
			}
		}

		// Token: 0x17001D31 RID: 7473
		// (get) Token: 0x0600611B RID: 24859 RVA: 0x001BB764 File Offset: 0x001B9964
		// (set) Token: 0x0600611C RID: 24860 RVA: 0x0002DDB4 File Offset: 0x0002BFB4
		public unsafe List<Type> allowedTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_allowedTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_allowedTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D32 RID: 7474
		// (get) Token: 0x0600611D RID: 24861 RVA: 0x001BB794 File Offset: 0x001B9994
		// (set) Token: 0x0600611E RID: 24862 RVA: 0x0002DDD3 File Offset: 0x0002BFD3
		public unsafe List<BuildableItem> selectedObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_selectedObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BuildableItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_selectedObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D33 RID: 7475
		// (get) Token: 0x0600611F RID: 24863 RVA: 0x001BB7C4 File Offset: 0x001B99C4
		// (set) Token: 0x06006120 RID: 24864 RVA: 0x0002DDF2 File Offset: 0x0002BFF2
		public unsafe List<Constructable> selectedConstructables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_selectedConstructables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Constructable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_selectedConstructables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D34 RID: 7476
		// (get) Token: 0x06006121 RID: 24865 RVA: 0x001BB7F4 File Offset: 0x001B99F4
		// (set) Token: 0x06006122 RID: 24866 RVA: 0x0002DE11 File Offset: 0x0002C011
		public unsafe Action onClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_onClose);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_onClose), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D35 RID: 7477
		// (get) Token: 0x06006123 RID: 24867 RVA: 0x001BB824 File Offset: 0x001B9A24
		// (set) Token: 0x06006124 RID: 24868 RVA: 0x0002DE30 File Offset: 0x0002C030
		public unsafe int selectionLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_selectionLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_selectionLimit)) = value;
			}
		}

		// Token: 0x17001D36 RID: 7478
		// (get) Token: 0x06006125 RID: 24869 RVA: 0x001BB84C File Offset: 0x001B9A4C
		// (set) Token: 0x06006126 RID: 24870 RVA: 0x0002DE4B File Offset: 0x0002C04B
		public unsafe bool exitOnSelectionLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_exitOnSelectionLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_exitOnSelectionLimit)) = value;
			}
		}

		// Token: 0x17001D37 RID: 7479
		// (get) Token: 0x06006127 RID: 24871 RVA: 0x001BB874 File Offset: 0x001B9A74
		// (set) Token: 0x06006128 RID: 24872 RVA: 0x0002DE66 File Offset: 0x0002C066
		public unsafe BuildableItem hoveredBuildable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_hoveredBuildable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuildableItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_hoveredBuildable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D38 RID: 7480
		// (get) Token: 0x06006129 RID: 24873 RVA: 0x001BB8A4 File Offset: 0x001B9AA4
		// (set) Token: 0x0600612A RID: 24874 RVA: 0x0002DE85 File Offset: 0x0002C085
		public unsafe Constructable hoveredConstructable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_hoveredConstructable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Constructable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_hoveredConstructable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D39 RID: 7481
		// (get) Token: 0x0600612B RID: 24875 RVA: 0x001BB8D4 File Offset: 0x001B9AD4
		// (set) Token: 0x0600612C RID: 24876 RVA: 0x0002DEA4 File Offset: 0x0002C0A4
		public unsafe List<BuildableItem> outlinedObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_outlinedObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BuildableItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_outlinedObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D3A RID: 7482
		// (get) Token: 0x0600612D RID: 24877 RVA: 0x001BB904 File Offset: 0x001B9B04
		// (set) Token: 0x0600612E RID: 24878 RVA: 0x0002DEC3 File Offset: 0x0002C0C3
		public unsafe List<Constructable> outlinedConstructables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_outlinedConstructables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Constructable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_outlinedConstructables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400423A RID: 16954
		private static readonly IntPtr NativeFieldInfoPtr_detectionRange;

		// Token: 0x0400423B RID: 16955
		private static readonly IntPtr NativeFieldInfoPtr_detectionMask;

		// Token: 0x0400423C RID: 16956
		private static readonly IntPtr NativeFieldInfoPtr__isSelecting_k__BackingField;

		// Token: 0x0400423D RID: 16957
		private static readonly IntPtr NativeFieldInfoPtr_allowedTypes;

		// Token: 0x0400423E RID: 16958
		private static readonly IntPtr NativeFieldInfoPtr_selectedObjects;

		// Token: 0x0400423F RID: 16959
		private static readonly IntPtr NativeFieldInfoPtr_selectedConstructables;

		// Token: 0x04004240 RID: 16960
		private static readonly IntPtr NativeFieldInfoPtr_onClose;

		// Token: 0x04004241 RID: 16961
		private static readonly IntPtr NativeFieldInfoPtr_selectionLimit;

		// Token: 0x04004242 RID: 16962
		private static readonly IntPtr NativeFieldInfoPtr_exitOnSelectionLimit;

		// Token: 0x04004243 RID: 16963
		private static readonly IntPtr NativeFieldInfoPtr_hoveredBuildable;

		// Token: 0x04004244 RID: 16964
		private static readonly IntPtr NativeFieldInfoPtr_hoveredConstructable;

		// Token: 0x04004245 RID: 16965
		private static readonly IntPtr NativeFieldInfoPtr_outlinedObjects;

		// Token: 0x04004246 RID: 16966
		private static readonly IntPtr NativeFieldInfoPtr_outlinedConstructables;

		// Token: 0x04004247 RID: 16967
		private static readonly IntPtr NativeMethodInfoPtr_get_isSelecting_Public_get_Boolean_0;

		// Token: 0x04004248 RID: 16968
		private static readonly IntPtr NativeMethodInfoPtr_set_isSelecting_Protected_set_Void_Boolean_0;

		// Token: 0x04004249 RID: 16969
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400424A RID: 16970
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x0400424B RID: 16971
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x0400424C RID: 16972
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredBuildable_Private_BuildableItem_0;

		// Token: 0x0400424D RID: 16973
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredConstructable_Private_Constructable_0;

		// Token: 0x0400424E RID: 16974
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x0400424F RID: 16975
		private static readonly IntPtr NativeMethodInfoPtr_StartSelecting_Public_Void_String_List_1_Type_byref_List_1_BuildableItem_byref_List_1_Constructable_Int32_Boolean_0;

		// Token: 0x04004250 RID: 16976
		private static readonly IntPtr NativeMethodInfoPtr_StopSelecting_Public_Void_0;

		// Token: 0x04004251 RID: 16977
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
