using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Delivery;
using Il2CppScheduleOne.UI.Tooltips;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.Delivery
{
	// Token: 0x020006AB RID: 1707
	public class DeliveryStatusDisplay : MonoBehaviour
	{
		// Token: 0x06009937 RID: 39223 RVA: 0x00270BA0 File Offset: 0x0026EDA0
		// Note: this type is marked as 'beforefieldinit'.
		static DeliveryStatusDisplay()
		{
			Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Delivery", "DeliveryStatusDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr);
			DeliveryStatusDisplay.NativeFieldInfoPtr__DeliveryInstance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "<DeliveryInstance>k__BackingField");
			DeliveryStatusDisplay.NativeFieldInfoPtr_ItemEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "ItemEntryPrefab");
			DeliveryStatusDisplay.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "Rect");
			DeliveryStatusDisplay.NativeFieldInfoPtr_DestinationLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "DestinationLabel");
			DeliveryStatusDisplay.NativeFieldInfoPtr_ShopLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "ShopLabel");
			DeliveryStatusDisplay.NativeFieldInfoPtr_StatusImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "StatusImage");
			DeliveryStatusDisplay.NativeFieldInfoPtr_StatusLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "StatusLabel");
			DeliveryStatusDisplay.NativeFieldInfoPtr_StatusTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "StatusTooltip");
			DeliveryStatusDisplay.NativeFieldInfoPtr_ItemEntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "ItemEntryContainer");
			DeliveryStatusDisplay.NativeFieldInfoPtr_StatusColor_Transit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "StatusColor_Transit");
			DeliveryStatusDisplay.NativeFieldInfoPtr_StatusColor_Waiting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "StatusColor_Waiting");
			DeliveryStatusDisplay.NativeFieldInfoPtr_StatusColor_Arrived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "StatusColor_Arrived");
			DeliveryStatusDisplay.NativeMethodInfoPtr_get_DeliveryInstance_Public_get_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, 100682206);
			DeliveryStatusDisplay.NativeMethodInfoPtr_set_DeliveryInstance_Private_set_Void_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, 100682207);
			DeliveryStatusDisplay.NativeMethodInfoPtr_AssignDelivery_Public_Void_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, 100682208);
			DeliveryStatusDisplay.NativeMethodInfoPtr_RefreshStatus_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, 100682209);
			DeliveryStatusDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, 100682210);
		}

		// Token: 0x17002F1D RID: 12061
		// (get) Token: 0x06009938 RID: 39224 RVA: 0x00270D24 File Offset: 0x0026EF24
		// (set) Token: 0x06009939 RID: 39225 RVA: 0x00270D64 File Offset: 0x0026EF64
		public unsafe DeliveryInstance DeliveryInstance
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17402, RefRangeEnd = 17403, XrefRangeStart = 17402, XrefRangeEnd = 17403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryStatusDisplay.NativeMethodInfoPtr_get_DeliveryInstance_Public_get_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeliveryInstance>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryStatusDisplay.NativeMethodInfoPtr_set_DeliveryInstance_Private_set_Void_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600993A RID: 39226 RVA: 0x00270DA8 File Offset: 0x0026EFA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 273421, RefRangeEnd = 273423, XrefRangeStart = 273385, XrefRangeEnd = 273421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignDelivery(DeliveryInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryStatusDisplay.NativeMethodInfoPtr_AssignDelivery_Public_Void_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600993B RID: 39227 RVA: 0x00270DEC File Offset: 0x0026EFEC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 273435, RefRangeEnd = 273438, XrefRangeStart = 273423, XrefRangeEnd = 273435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryStatusDisplay.NativeMethodInfoPtr_RefreshStatus_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600993C RID: 39228 RVA: 0x00270E20 File Offset: 0x0026F020
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryStatusDisplay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryStatusDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600993D RID: 39229 RVA: 0x0004AB02 File Offset: 0x00048D02
		public DeliveryStatusDisplay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002F11 RID: 12049
		// (get) Token: 0x0600993E RID: 39230 RVA: 0x00270E5C File Offset: 0x0026F05C
		// (set) Token: 0x0600993F RID: 39231 RVA: 0x0004AB0B File Offset: 0x00048D0B
		public unsafe DeliveryInstance _DeliveryInstance_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr__DeliveryInstance_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr__DeliveryInstance_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F12 RID: 12050
		// (get) Token: 0x06009940 RID: 39232 RVA: 0x00270E8C File Offset: 0x0026F08C
		// (set) Token: 0x06009941 RID: 39233 RVA: 0x0004AB2A File Offset: 0x00048D2A
		public unsafe GameObject ItemEntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_ItemEntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_ItemEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F13 RID: 12051
		// (get) Token: 0x06009942 RID: 39234 RVA: 0x00270EBC File Offset: 0x0026F0BC
		// (set) Token: 0x06009943 RID: 39235 RVA: 0x0004AB49 File Offset: 0x00048D49
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F14 RID: 12052
		// (get) Token: 0x06009944 RID: 39236 RVA: 0x00270EEC File Offset: 0x0026F0EC
		// (set) Token: 0x06009945 RID: 39237 RVA: 0x0004AB68 File Offset: 0x00048D68
		public unsafe Text DestinationLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_DestinationLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_DestinationLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F15 RID: 12053
		// (get) Token: 0x06009946 RID: 39238 RVA: 0x00270F1C File Offset: 0x0026F11C
		// (set) Token: 0x06009947 RID: 39239 RVA: 0x0004AB87 File Offset: 0x00048D87
		public unsafe Text ShopLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_ShopLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_ShopLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F16 RID: 12054
		// (get) Token: 0x06009948 RID: 39240 RVA: 0x00270F4C File Offset: 0x0026F14C
		// (set) Token: 0x06009949 RID: 39241 RVA: 0x0004ABA6 File Offset: 0x00048DA6
		public unsafe Image StatusImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F17 RID: 12055
		// (get) Token: 0x0600994A RID: 39242 RVA: 0x00270F7C File Offset: 0x0026F17C
		// (set) Token: 0x0600994B RID: 39243 RVA: 0x0004ABC5 File Offset: 0x00048DC5
		public unsafe Text StatusLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F18 RID: 12056
		// (get) Token: 0x0600994C RID: 39244 RVA: 0x00270FAC File Offset: 0x0026F1AC
		// (set) Token: 0x0600994D RID: 39245 RVA: 0x0004ABE4 File Offset: 0x00048DE4
		public unsafe Tooltip StatusTooltip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusTooltip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tooltip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusTooltip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F19 RID: 12057
		// (get) Token: 0x0600994E RID: 39246 RVA: 0x00270FDC File Offset: 0x0026F1DC
		// (set) Token: 0x0600994F RID: 39247 RVA: 0x0004AC03 File Offset: 0x00048E03
		public unsafe RectTransform ItemEntryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_ItemEntryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_ItemEntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F1A RID: 12058
		// (get) Token: 0x06009950 RID: 39248 RVA: 0x0027100C File Offset: 0x0026F20C
		// (set) Token: 0x06009951 RID: 39249 RVA: 0x0004AC22 File Offset: 0x00048E22
		public unsafe Color StatusColor_Transit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusColor_Transit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusColor_Transit)) = value;
			}
		}

		// Token: 0x17002F1B RID: 12059
		// (get) Token: 0x06009952 RID: 39250 RVA: 0x00271034 File Offset: 0x0026F234
		// (set) Token: 0x06009953 RID: 39251 RVA: 0x0004AC3D File Offset: 0x00048E3D
		public unsafe Color StatusColor_Waiting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusColor_Waiting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusColor_Waiting)) = value;
			}
		}

		// Token: 0x17002F1C RID: 12060
		// (get) Token: 0x06009954 RID: 39252 RVA: 0x0027105C File Offset: 0x0026F25C
		// (set) Token: 0x06009955 RID: 39253 RVA: 0x0004AC58 File Offset: 0x00048E58
		public unsafe Color StatusColor_Arrived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusColor_Arrived);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusColor_Arrived)) = value;
			}
		}

		// Token: 0x0400672A RID: 26410
		private static readonly IntPtr NativeFieldInfoPtr__DeliveryInstance_k__BackingField;

		// Token: 0x0400672B RID: 26411
		private static readonly IntPtr NativeFieldInfoPtr_ItemEntryPrefab;

		// Token: 0x0400672C RID: 26412
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x0400672D RID: 26413
		private static readonly IntPtr NativeFieldInfoPtr_DestinationLabel;

		// Token: 0x0400672E RID: 26414
		private static readonly IntPtr NativeFieldInfoPtr_ShopLabel;

		// Token: 0x0400672F RID: 26415
		private static readonly IntPtr NativeFieldInfoPtr_StatusImage;

		// Token: 0x04006730 RID: 26416
		private static readonly IntPtr NativeFieldInfoPtr_StatusLabel;

		// Token: 0x04006731 RID: 26417
		private static readonly IntPtr NativeFieldInfoPtr_StatusTooltip;

		// Token: 0x04006732 RID: 26418
		private static readonly IntPtr NativeFieldInfoPtr_ItemEntryContainer;

		// Token: 0x04006733 RID: 26419
		private static readonly IntPtr NativeFieldInfoPtr_StatusColor_Transit;

		// Token: 0x04006734 RID: 26420
		private static readonly IntPtr NativeFieldInfoPtr_StatusColor_Waiting;

		// Token: 0x04006735 RID: 26421
		private static readonly IntPtr NativeFieldInfoPtr_StatusColor_Arrived;

		// Token: 0x04006736 RID: 26422
		private static readonly IntPtr NativeMethodInfoPtr_get_DeliveryInstance_Public_get_DeliveryInstance_0;

		// Token: 0x04006737 RID: 26423
		private static readonly IntPtr NativeMethodInfoPtr_set_DeliveryInstance_Private_set_Void_DeliveryInstance_0;

		// Token: 0x04006738 RID: 26424
		private static readonly IntPtr NativeMethodInfoPtr_AssignDelivery_Public_Void_DeliveryInstance_0;

		// Token: 0x04006739 RID: 26425
		private static readonly IntPtr NativeMethodInfoPtr_RefreshStatus_Public_Void_0;

		// Token: 0x0400673A RID: 26426
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
