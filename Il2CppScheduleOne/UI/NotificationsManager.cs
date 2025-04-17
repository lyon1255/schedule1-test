using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200064C RID: 1612
	public class NotificationsManager : Singleton<NotificationsManager>
	{
		// Token: 0x06008F14 RID: 36628 RVA: 0x00252448 File Offset: 0x00250648
		// Note: this type is marked as 'beforefieldinit'.
		static NotificationsManager()
		{
			Il2CppClassPointerStore<NotificationsManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "NotificationsManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotificationsManager>.NativeClassPtr);
			NotificationsManager.NativeFieldInfoPtr_MAX_NOTIFICATIONS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager>.NativeClassPtr, "MAX_NOTIFICATIONS");
			NotificationsManager.NativeFieldInfoPtr_EntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager>.NativeClassPtr, "EntryContainer");
			NotificationsManager.NativeFieldInfoPtr_Sound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager>.NativeClassPtr, "Sound");
			NotificationsManager.NativeFieldInfoPtr_NotificationPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager>.NativeClassPtr, "NotificationPrefab");
			NotificationsManager.NativeFieldInfoPtr_coroutines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager>.NativeClassPtr, "coroutines");
			NotificationsManager.NativeFieldInfoPtr_entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager>.NativeClassPtr, "entries");
			NotificationsManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsManager>.NativeClassPtr, 100681044);
			NotificationsManager.NativeMethodInfoPtr_SendNotification_Public_Void_String_String_Sprite_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsManager>.NativeClassPtr, 100681045);
			NotificationsManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsManager>.NativeClassPtr, 100681046);
		}

		// Token: 0x06008F15 RID: 36629 RVA: 0x0025252C File Offset: 0x0025072C
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F16 RID: 36630 RVA: 0x00252560 File Offset: 0x00250760
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 259793, RefRangeEnd = 259800, XrefRangeStart = 259717, XrefRangeEnd = 259793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendNotification(string title, string subtitle, Sprite icon, float duration = 5f, bool playSound = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(subtitle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(icon);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playSound;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsManager.NativeMethodInfoPtr_SendNotification_Public_Void_String_String_Sprite_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F17 RID: 36631 RVA: 0x002525E4 File Offset: 0x002507E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259800, XrefRangeEnd = 259817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NotificationsManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotificationsManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F18 RID: 36632 RVA: 0x00044F01 File Offset: 0x00043101
		public NotificationsManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002BC1 RID: 11201
		// (get) Token: 0x06008F19 RID: 36633 RVA: 0x00252620 File Offset: 0x00250820
		// (set) Token: 0x06008F1A RID: 36634 RVA: 0x00044F0A File Offset: 0x0004310A
		public unsafe static int MAX_NOTIFICATIONS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(NotificationsManager.NativeFieldInfoPtr_MAX_NOTIFICATIONS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NotificationsManager.NativeFieldInfoPtr_MAX_NOTIFICATIONS, (void*)(&value));
			}
		}

		// Token: 0x17002BC2 RID: 11202
		// (get) Token: 0x06008F1B RID: 36635 RVA: 0x0025263C File Offset: 0x0025083C
		// (set) Token: 0x06008F1C RID: 36636 RVA: 0x00044F18 File Offset: 0x00043118
		public unsafe RectTransform EntryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.NativeFieldInfoPtr_EntryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.NativeFieldInfoPtr_EntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BC3 RID: 11203
		// (get) Token: 0x06008F1D RID: 36637 RVA: 0x0025266C File Offset: 0x0025086C
		// (set) Token: 0x06008F1E RID: 36638 RVA: 0x00044F37 File Offset: 0x00043137
		public unsafe AudioSourceController Sound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.NativeFieldInfoPtr_Sound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.NativeFieldInfoPtr_Sound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BC4 RID: 11204
		// (get) Token: 0x06008F1F RID: 36639 RVA: 0x0025269C File Offset: 0x0025089C
		// (set) Token: 0x06008F20 RID: 36640 RVA: 0x00044F56 File Offset: 0x00043156
		public unsafe GameObject NotificationPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.NativeFieldInfoPtr_NotificationPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.NativeFieldInfoPtr_NotificationPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BC5 RID: 11205
		// (get) Token: 0x06008F21 RID: 36641 RVA: 0x002526CC File Offset: 0x002508CC
		// (set) Token: 0x06008F22 RID: 36642 RVA: 0x00044F75 File Offset: 0x00043175
		public unsafe Dictionary<RectTransform, Coroutine> coroutines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.NativeFieldInfoPtr_coroutines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<RectTransform, Coroutine>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.NativeFieldInfoPtr_coroutines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BC6 RID: 11206
		// (get) Token: 0x06008F23 RID: 36643 RVA: 0x002526FC File Offset: 0x002508FC
		// (set) Token: 0x06008F24 RID: 36644 RVA: 0x00044F94 File Offset: 0x00043194
		public unsafe List<RectTransform> entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.NativeFieldInfoPtr_entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.NativeFieldInfoPtr_entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040060D0 RID: 24784
		private static readonly IntPtr NativeFieldInfoPtr_MAX_NOTIFICATIONS;

		// Token: 0x040060D1 RID: 24785
		private static readonly IntPtr NativeFieldInfoPtr_EntryContainer;

		// Token: 0x040060D2 RID: 24786
		private static readonly IntPtr NativeFieldInfoPtr_Sound;

		// Token: 0x040060D3 RID: 24787
		private static readonly IntPtr NativeFieldInfoPtr_NotificationPrefab;

		// Token: 0x040060D4 RID: 24788
		private static readonly IntPtr NativeFieldInfoPtr_coroutines;

		// Token: 0x040060D5 RID: 24789
		private static readonly IntPtr NativeFieldInfoPtr_entries;

		// Token: 0x040060D6 RID: 24790
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040060D7 RID: 24791
		private static readonly IntPtr NativeMethodInfoPtr_SendNotification_Public_Void_String_String_Sprite_Single_Boolean_0;

		// Token: 0x040060D8 RID: 24792
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B31 RID: 2865
		[ObfuscatedName("ScheduleOne.UI.NotificationsManager+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D80E RID: 55310 RVA: 0x003354A8 File Offset: 0x003336A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NotificationsManager>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0>.NativeClassPtr);
				NotificationsManager.__c__DisplayClass7_0.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0>.NativeClassPtr, "container");
				NotificationsManager.__c__DisplayClass7_0.NativeFieldInfoPtr_startX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0>.NativeClassPtr, "startX");
				NotificationsManager.__c__DisplayClass7_0.NativeFieldInfoPtr_endX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0>.NativeClassPtr, "endX");
				NotificationsManager.__c__DisplayClass7_0.NativeFieldInfoPtr_lerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0>.NativeClassPtr, "lerpTime");
				NotificationsManager.__c__DisplayClass7_0.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0>.NativeClassPtr, "duration");
				NotificationsManager.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
				NotificationsManager.__c__DisplayClass7_0.NativeFieldInfoPtr_newEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0>.NativeClassPtr, "newEntry");
				NotificationsManager.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0>.NativeClassPtr, 100681047);
				NotificationsManager.__c__DisplayClass7_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0>.NativeClassPtr, 100681048);
			}

			// Token: 0x0600D80F RID: 55311 RVA: 0x00335588 File Offset: 0x00333788
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsManager.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D810 RID: 55312 RVA: 0x003355C4 File Offset: 0x003337C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259712, XrefRangeEnd = 259717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsManager.__c__DisplayClass7_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D811 RID: 55313 RVA: 0x0006933E File Offset: 0x0006753E
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042F8 RID: 17144
			// (get) Token: 0x0600D812 RID: 55314 RVA: 0x00335604 File Offset: 0x00333804
			// (set) Token: 0x0600D813 RID: 55315 RVA: 0x00069347 File Offset: 0x00067547
			public unsafe RectTransform container
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass7_0.NativeFieldInfoPtr_container);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass7_0.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042F9 RID: 17145
			// (get) Token: 0x0600D814 RID: 55316 RVA: 0x00335634 File Offset: 0x00333834
			// (set) Token: 0x0600D815 RID: 55317 RVA: 0x00069366 File Offset: 0x00067566
			public unsafe float startX
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass7_0.NativeFieldInfoPtr_startX);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass7_0.NativeFieldInfoPtr_startX)) = value;
				}
			}

			// Token: 0x170042FA RID: 17146
			// (get) Token: 0x0600D816 RID: 55318 RVA: 0x0033565C File Offset: 0x0033385C
			// (set) Token: 0x0600D817 RID: 55319 RVA: 0x00069381 File Offset: 0x00067581
			public unsafe float endX
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass7_0.NativeFieldInfoPtr_endX);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass7_0.NativeFieldInfoPtr_endX)) = value;
				}
			}

			// Token: 0x170042FB RID: 17147
			// (get) Token: 0x0600D818 RID: 55320 RVA: 0x00335684 File Offset: 0x00333884
			// (set) Token: 0x0600D819 RID: 55321 RVA: 0x0006939C File Offset: 0x0006759C
			public unsafe float lerpTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass7_0.NativeFieldInfoPtr_lerpTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass7_0.NativeFieldInfoPtr_lerpTime)) = value;
				}
			}

			// Token: 0x170042FC RID: 17148
			// (get) Token: 0x0600D81A RID: 55322 RVA: 0x003356AC File Offset: 0x003338AC
			// (set) Token: 0x0600D81B RID: 55323 RVA: 0x000693B7 File Offset: 0x000675B7
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass7_0.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass7_0.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x170042FD RID: 17149
			// (get) Token: 0x0600D81C RID: 55324 RVA: 0x003356D4 File Offset: 0x003338D4
			// (set) Token: 0x0600D81D RID: 55325 RVA: 0x000693D2 File Offset: 0x000675D2
			public unsafe NotificationsManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NotificationsManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042FE RID: 17150
			// (get) Token: 0x0600D81E RID: 55326 RVA: 0x00335704 File Offset: 0x00333904
			// (set) Token: 0x0600D81F RID: 55327 RVA: 0x000693F1 File Offset: 0x000675F1
			public unsafe RectTransform newEntry
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass7_0.NativeFieldInfoPtr_newEntry);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass7_0.NativeFieldInfoPtr_newEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400912B RID: 37163
			private static readonly IntPtr NativeFieldInfoPtr_container;

			// Token: 0x0400912C RID: 37164
			private static readonly IntPtr NativeFieldInfoPtr_startX;

			// Token: 0x0400912D RID: 37165
			private static readonly IntPtr NativeFieldInfoPtr_endX;

			// Token: 0x0400912E RID: 37166
			private static readonly IntPtr NativeFieldInfoPtr_lerpTime;

			// Token: 0x0400912F RID: 37167
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x04009130 RID: 37168
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009131 RID: 37169
			private static readonly IntPtr NativeFieldInfoPtr_newEntry;

			// Token: 0x04009132 RID: 37170
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009133 RID: 37171
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C76 RID: 3190
			[ObfuscatedName("ScheduleOne.UI.NotificationsManager+<>c__DisplayClass7_0+<<SendNotification>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E591 RID: 58769 RVA: 0x0035C524 File Offset: 0x0035A724
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique()
				{
					Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0>.NativeClassPtr, "<<SendNotification>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr);
					NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>1__state");
					NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>2__current");
					NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>4__this");
					NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<i>5__2");
					NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100681049);
					NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100681050);
					NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100681051);
					NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100681052);
					NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100681053);
					NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100681054);
				}

				// Token: 0x0600E592 RID: 58770 RVA: 0x0035C618 File Offset: 0x0035A818
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E593 RID: 58771 RVA: 0x0035C660 File Offset: 0x0035A860
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E594 RID: 58772 RVA: 0x0035C694 File Offset: 0x0035A894
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259693, XrefRangeEnd = 259707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004768 RID: 18280
				// (get) Token: 0x0600E595 RID: 58773 RVA: 0x0035C6D0 File Offset: 0x0035A8D0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E596 RID: 58774 RVA: 0x0035C710 File Offset: 0x0035A910
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259707, XrefRangeEnd = 259712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004769 RID: 18281
				// (get) Token: 0x0600E597 RID: 58775 RVA: 0x0035C744 File Offset: 0x0035A944
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E598 RID: 58776 RVA: 0x0006FFA5 File Offset: 0x0006E1A5
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004764 RID: 18276
				// (get) Token: 0x0600E599 RID: 58777 RVA: 0x0035C784 File Offset: 0x0035A984
				// (set) Token: 0x0600E59A RID: 58778 RVA: 0x0006FFAE File Offset: 0x0006E1AE
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004765 RID: 18277
				// (get) Token: 0x0600E59B RID: 58779 RVA: 0x0035C7AC File Offset: 0x0035A9AC
				// (set) Token: 0x0600E59C RID: 58780 RVA: 0x0006FFC9 File Offset: 0x0006E1C9
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004766 RID: 18278
				// (get) Token: 0x0600E59D RID: 58781 RVA: 0x0035C7DC File Offset: 0x0035A9DC
				// (set) Token: 0x0600E59E RID: 58782 RVA: 0x0006FFE8 File Offset: 0x0006E1E8
				public unsafe NotificationsManager.__c__DisplayClass7_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<NotificationsManager.__c__DisplayClass7_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004767 RID: 18279
				// (get) Token: 0x0600E59F RID: 58783 RVA: 0x0035C80C File Offset: 0x0035AA0C
				// (set) Token: 0x0600E5A0 RID: 58784 RVA: 0x00070007 File Offset: 0x0006E207
				public unsafe float _i_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2)) = value;
					}
				}

				// Token: 0x0400997E RID: 39294
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400997F RID: 39295
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009980 RID: 39296
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009981 RID: 39297
				private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

				// Token: 0x04009982 RID: 39298
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009983 RID: 39299
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009984 RID: 39300
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009985 RID: 39301
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009986 RID: 39302
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009987 RID: 39303
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
