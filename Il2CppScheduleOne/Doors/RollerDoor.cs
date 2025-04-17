using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Doors
{
	// Token: 0x02000427 RID: 1063
	public class RollerDoor : MonoBehaviour
	{
		// Token: 0x06005D85 RID: 23941 RVA: 0x001AF8AC File Offset: 0x001ADAAC
		// Note: this type is marked as 'beforefieldinit'.
		static RollerDoor()
		{
			Il2CppClassPointerStore<RollerDoor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Doors", "RollerDoor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr);
			RollerDoor.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, "<IsOpen>k__BackingField");
			RollerDoor.NativeFieldInfoPtr_Door = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, "Door");
			RollerDoor.NativeFieldInfoPtr_LocalPos_Open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, "LocalPos_Open");
			RollerDoor.NativeFieldInfoPtr_LocalPos_Closed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, "LocalPos_Closed");
			RollerDoor.NativeFieldInfoPtr_LerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, "LerpTime");
			RollerDoor.NativeFieldInfoPtr_Blocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, "Blocker");
			RollerDoor.NativeFieldInfoPtr_startPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, "startPos");
			RollerDoor.NativeFieldInfoPtr_timeSinceValueChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, "timeSinceValueChange");
			RollerDoor.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, 100675203);
			RollerDoor.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, 100675204);
			RollerDoor.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, 100675205);
			RollerDoor.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, 100675206);
			RollerDoor.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, 100675207);
			RollerDoor.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, 100675208);
			RollerDoor.NativeMethodInfoPtr_CanOpen_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, 100675209);
			RollerDoor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, 100675210);
		}

		// Token: 0x17001C2E RID: 7214
		// (get) Token: 0x06005D86 RID: 23942 RVA: 0x001AFA1C File Offset: 0x001ADC1C
		// (set) Token: 0x06005D87 RID: 23943 RVA: 0x001AFA58 File Offset: 0x001ADC58
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RollerDoor.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RollerDoor.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005D88 RID: 23944 RVA: 0x001AFA98 File Offset: 0x001ADC98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195938, XrefRangeEnd = 195940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RollerDoor.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D89 RID: 23945 RVA: 0x001AFACC File Offset: 0x001ADCCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195940, XrefRangeEnd = 195952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RollerDoor.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D8A RID: 23946 RVA: 0x001AFB00 File Offset: 0x001ADD00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195952, XrefRangeEnd = 195953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RollerDoor.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D8B RID: 23947 RVA: 0x001AFB34 File Offset: 0x001ADD34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195954, RefRangeEnd = 195955, XrefRangeStart = 195953, XrefRangeEnd = 195954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RollerDoor.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D8C RID: 23948 RVA: 0x001AFB68 File Offset: 0x001ADD68
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RollerDoor.NativeMethodInfoPtr_CanOpen_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005D8D RID: 23949 RVA: 0x001AFBB0 File Offset: 0x001ADDB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195955, XrefRangeEnd = 195958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RollerDoor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RollerDoor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D8E RID: 23950 RVA: 0x0002C153 File Offset: 0x0002A353
		public RollerDoor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C26 RID: 7206
		// (get) Token: 0x06005D8F RID: 23951 RVA: 0x001AFBEC File Offset: 0x001ADDEC
		// (set) Token: 0x06005D90 RID: 23952 RVA: 0x0002C15C File Offset: 0x0002A35C
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17001C27 RID: 7207
		// (get) Token: 0x06005D91 RID: 23953 RVA: 0x001AFC14 File Offset: 0x001ADE14
		// (set) Token: 0x06005D92 RID: 23954 RVA: 0x0002C177 File Offset: 0x0002A377
		public unsafe Transform Door
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_Door);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_Door), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C28 RID: 7208
		// (get) Token: 0x06005D93 RID: 23955 RVA: 0x001AFC44 File Offset: 0x001ADE44
		// (set) Token: 0x06005D94 RID: 23956 RVA: 0x0002C196 File Offset: 0x0002A396
		public unsafe Vector3 LocalPos_Open
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_LocalPos_Open);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_LocalPos_Open)) = value;
			}
		}

		// Token: 0x17001C29 RID: 7209
		// (get) Token: 0x06005D95 RID: 23957 RVA: 0x001AFC6C File Offset: 0x001ADE6C
		// (set) Token: 0x06005D96 RID: 23958 RVA: 0x0002C1B1 File Offset: 0x0002A3B1
		public unsafe Vector3 LocalPos_Closed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_LocalPos_Closed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_LocalPos_Closed)) = value;
			}
		}

		// Token: 0x17001C2A RID: 7210
		// (get) Token: 0x06005D97 RID: 23959 RVA: 0x001AFC94 File Offset: 0x001ADE94
		// (set) Token: 0x06005D98 RID: 23960 RVA: 0x0002C1CC File Offset: 0x0002A3CC
		public unsafe float LerpTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_LerpTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_LerpTime)) = value;
			}
		}

		// Token: 0x17001C2B RID: 7211
		// (get) Token: 0x06005D99 RID: 23961 RVA: 0x001AFCBC File Offset: 0x001ADEBC
		// (set) Token: 0x06005D9A RID: 23962 RVA: 0x0002C1E7 File Offset: 0x0002A3E7
		public unsafe GameObject Blocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_Blocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_Blocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C2C RID: 7212
		// (get) Token: 0x06005D9B RID: 23963 RVA: 0x001AFCEC File Offset: 0x001ADEEC
		// (set) Token: 0x06005D9C RID: 23964 RVA: 0x0002C206 File Offset: 0x0002A406
		public unsafe Vector3 startPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_startPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_startPos)) = value;
			}
		}

		// Token: 0x17001C2D RID: 7213
		// (get) Token: 0x06005D9D RID: 23965 RVA: 0x001AFD14 File Offset: 0x001ADF14
		// (set) Token: 0x06005D9E RID: 23966 RVA: 0x0002C221 File Offset: 0x0002A421
		public unsafe float timeSinceValueChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_timeSinceValueChange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_timeSinceValueChange)) = value;
			}
		}

		// Token: 0x04004000 RID: 16384
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04004001 RID: 16385
		private static readonly IntPtr NativeFieldInfoPtr_Door;

		// Token: 0x04004002 RID: 16386
		private static readonly IntPtr NativeFieldInfoPtr_LocalPos_Open;

		// Token: 0x04004003 RID: 16387
		private static readonly IntPtr NativeFieldInfoPtr_LocalPos_Closed;

		// Token: 0x04004004 RID: 16388
		private static readonly IntPtr NativeFieldInfoPtr_LerpTime;

		// Token: 0x04004005 RID: 16389
		private static readonly IntPtr NativeFieldInfoPtr_Blocker;

		// Token: 0x04004006 RID: 16390
		private static readonly IntPtr NativeFieldInfoPtr_startPos;

		// Token: 0x04004007 RID: 16391
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceValueChange;

		// Token: 0x04004008 RID: 16392
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04004009 RID: 16393
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x0400400A RID: 16394
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400400B RID: 16395
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x0400400C RID: 16396
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x0400400D RID: 16397
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x0400400E RID: 16398
		private static readonly IntPtr NativeMethodInfoPtr_CanOpen_Protected_Virtual_New_Boolean_0;

		// Token: 0x0400400F RID: 16399
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
