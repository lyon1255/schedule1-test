using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006D0 RID: 1744
	public class NPCSelector : MonoBehaviour
	{
		// Token: 0x06009CC4 RID: 40132 RVA: 0x0027B0F4 File Offset: 0x002792F4
		// Note: this type is marked as 'beforefieldinit'.
		static NPCSelector()
		{
			Il2CppClassPointerStore<NPCSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "NPCSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr);
			NPCSelector.NativeFieldInfoPtr_SELECTION_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, "SELECTION_RANGE");
			NPCSelector.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, "<IsOpen>k__BackingField");
			NPCSelector.NativeFieldInfoPtr_DetectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, "DetectionMask");
			NPCSelector.NativeFieldInfoPtr_HoverOutlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, "HoverOutlineColor");
			NPCSelector.NativeFieldInfoPtr_TypeRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, "TypeRequirement");
			NPCSelector.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, "callback");
			NPCSelector.NativeFieldInfoPtr_hoveredNPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, "hoveredNPC");
			NPCSelector.NativeFieldInfoPtr_highlightedNPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, "highlightedNPC");
			NPCSelector.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, 100682544);
			NPCSelector.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, 100682545);
			NPCSelector.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, 100682546);
			NPCSelector.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_String_Type_Action_1_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, 100682547);
			NPCSelector.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, 100682548);
			NPCSelector.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, 100682549);
			NPCSelector.NativeMethodInfoPtr_GetHoveredNPC_Private_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, 100682550);
			NPCSelector.NativeMethodInfoPtr_IsNPCTypeValid_Public_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, 100682551);
			NPCSelector.NativeMethodInfoPtr_NPCClicked_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, 100682552);
			NPCSelector.NativeMethodInfoPtr_ClipboardClosed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, 100682553);
			NPCSelector.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, 100682554);
			NPCSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, 100682555);
		}

		// Token: 0x1700304D RID: 12365
		// (get) Token: 0x06009CC5 RID: 40133 RVA: 0x0027B2B4 File Offset: 0x002794B4
		// (set) Token: 0x06009CC6 RID: 40134 RVA: 0x0027B2F0 File Offset: 0x002794F0
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSelector.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35362, RefRangeEnd = 35364, XrefRangeStart = 35362, XrefRangeEnd = 35364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSelector.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009CC7 RID: 40135 RVA: 0x0027B330 File Offset: 0x00279530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278260, XrefRangeEnd = 278282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSelector.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CC8 RID: 40136 RVA: 0x0027B364 File Offset: 0x00279564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278282, XrefRangeEnd = 278307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Open(string selectionTitle, Type typeRequirement, Action<NPC> _callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(selectionTitle);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeRequirement);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSelector.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_String_Type_Action_1_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CC9 RID: 40137 RVA: 0x0027B3D8 File Offset: 0x002795D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278307, XrefRangeEnd = 278345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close(bool returnToClipboard)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref returnToClipboard;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSelector.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CCA RID: 40138 RVA: 0x0027B424 File Offset: 0x00279624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278345, XrefRangeEnd = 278380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSelector.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CCB RID: 40139 RVA: 0x0027B458 File Offset: 0x00279658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278380, XrefRangeEnd = 278386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPC GetHoveredNPC()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSelector.NativeMethodInfoPtr_GetHoveredNPC_Private_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr3) : null;
		}

		// Token: 0x06009CCC RID: 40140 RVA: 0x0027B498 File Offset: 0x00279698
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 278391, RefRangeEnd = 278395, XrefRangeStart = 278386, XrefRangeEnd = 278391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsNPCTypeValid(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSelector.NativeMethodInfoPtr_IsNPCTypeValid_Public_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009CCD RID: 40141 RVA: 0x0027B4E8 File Offset: 0x002796E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278395, XrefRangeEnd = 278396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NPCClicked(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSelector.NativeMethodInfoPtr_NPCClicked_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CCE RID: 40142 RVA: 0x0027B52C File Offset: 0x0027972C
		[CallerCount(0)]
		public unsafe void ClipboardClosed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSelector.NativeMethodInfoPtr_ClipboardClosed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CCF RID: 40143 RVA: 0x0027B560 File Offset: 0x00279760
		[CallerCount(0)]
		public unsafe void Exit(ExitAction exitAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exitAction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSelector.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CD0 RID: 40144 RVA: 0x0027B5A4 File Offset: 0x002797A4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCSelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CD1 RID: 40145 RVA: 0x0004CDDC File Offset: 0x0004AFDC
		public NPCSelector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003045 RID: 12357
		// (get) Token: 0x06009CD2 RID: 40146 RVA: 0x0027B5E0 File Offset: 0x002797E0
		// (set) Token: 0x06009CD3 RID: 40147 RVA: 0x0004CDE5 File Offset: 0x0004AFE5
		public unsafe static float SELECTION_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCSelector.NativeFieldInfoPtr_SELECTION_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCSelector.NativeFieldInfoPtr_SELECTION_RANGE, (void*)(&value));
			}
		}

		// Token: 0x17003046 RID: 12358
		// (get) Token: 0x06009CD4 RID: 40148 RVA: 0x0027B5FC File Offset: 0x002797FC
		// (set) Token: 0x06009CD5 RID: 40149 RVA: 0x0004CDF3 File Offset: 0x0004AFF3
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSelector.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSelector.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003047 RID: 12359
		// (get) Token: 0x06009CD6 RID: 40150 RVA: 0x0027B624 File Offset: 0x00279824
		// (set) Token: 0x06009CD7 RID: 40151 RVA: 0x0004CE0E File Offset: 0x0004B00E
		public unsafe LayerMask DetectionMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSelector.NativeFieldInfoPtr_DetectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSelector.NativeFieldInfoPtr_DetectionMask)) = value;
			}
		}

		// Token: 0x17003048 RID: 12360
		// (get) Token: 0x06009CD8 RID: 40152 RVA: 0x0027B64C File Offset: 0x0027984C
		// (set) Token: 0x06009CD9 RID: 40153 RVA: 0x0004CE29 File Offset: 0x0004B029
		public unsafe Color HoverOutlineColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSelector.NativeFieldInfoPtr_HoverOutlineColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSelector.NativeFieldInfoPtr_HoverOutlineColor)) = value;
			}
		}

		// Token: 0x17003049 RID: 12361
		// (get) Token: 0x06009CDA RID: 40154 RVA: 0x0027B674 File Offset: 0x00279874
		// (set) Token: 0x06009CDB RID: 40155 RVA: 0x0004CE44 File Offset: 0x0004B044
		public unsafe Type TypeRequirement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSelector.NativeFieldInfoPtr_TypeRequirement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSelector.NativeFieldInfoPtr_TypeRequirement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700304A RID: 12362
		// (get) Token: 0x06009CDC RID: 40156 RVA: 0x0027B6A4 File Offset: 0x002798A4
		// (set) Token: 0x06009CDD RID: 40157 RVA: 0x0004CE63 File Offset: 0x0004B063
		public unsafe Action<NPC> callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSelector.NativeFieldInfoPtr_callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<NPC>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSelector.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700304B RID: 12363
		// (get) Token: 0x06009CDE RID: 40158 RVA: 0x0027B6D4 File Offset: 0x002798D4
		// (set) Token: 0x06009CDF RID: 40159 RVA: 0x0004CE82 File Offset: 0x0004B082
		public unsafe NPC hoveredNPC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSelector.NativeFieldInfoPtr_hoveredNPC);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSelector.NativeFieldInfoPtr_hoveredNPC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700304C RID: 12364
		// (get) Token: 0x06009CE0 RID: 40160 RVA: 0x0027B704 File Offset: 0x00279904
		// (set) Token: 0x06009CE1 RID: 40161 RVA: 0x0004CEA1 File Offset: 0x0004B0A1
		public unsafe NPC highlightedNPC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSelector.NativeFieldInfoPtr_highlightedNPC);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSelector.NativeFieldInfoPtr_highlightedNPC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400694C RID: 26956
		private static readonly IntPtr NativeFieldInfoPtr_SELECTION_RANGE;

		// Token: 0x0400694D RID: 26957
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x0400694E RID: 26958
		private static readonly IntPtr NativeFieldInfoPtr_DetectionMask;

		// Token: 0x0400694F RID: 26959
		private static readonly IntPtr NativeFieldInfoPtr_HoverOutlineColor;

		// Token: 0x04006950 RID: 26960
		private static readonly IntPtr NativeFieldInfoPtr_TypeRequirement;

		// Token: 0x04006951 RID: 26961
		private static readonly IntPtr NativeFieldInfoPtr_callback;

		// Token: 0x04006952 RID: 26962
		private static readonly IntPtr NativeFieldInfoPtr_hoveredNPC;

		// Token: 0x04006953 RID: 26963
		private static readonly IntPtr NativeFieldInfoPtr_highlightedNPC;

		// Token: 0x04006954 RID: 26964
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04006955 RID: 26965
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006956 RID: 26966
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04006957 RID: 26967
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_New_Void_String_Type_Action_1_NPC_0;

		// Token: 0x04006958 RID: 26968
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04006959 RID: 26969
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400695A RID: 26970
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredNPC_Private_NPC_0;

		// Token: 0x0400695B RID: 26971
		private static readonly IntPtr NativeMethodInfoPtr_IsNPCTypeValid_Public_Boolean_NPC_0;

		// Token: 0x0400695C RID: 26972
		private static readonly IntPtr NativeMethodInfoPtr_NPCClicked_Public_Void_NPC_0;

		// Token: 0x0400695D RID: 26973
		private static readonly IntPtr NativeMethodInfoPtr_ClipboardClosed_Private_Void_0;

		// Token: 0x0400695E RID: 26974
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x0400695F RID: 26975
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
