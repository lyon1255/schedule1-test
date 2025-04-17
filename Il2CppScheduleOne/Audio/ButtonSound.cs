using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004CF RID: 1231
	public class ButtonSound : MonoBehaviour
	{
		// Token: 0x06006BD8 RID: 27608 RVA: 0x001DFA7C File Offset: 0x001DDC7C
		// Note: this type is marked as 'beforefieldinit'.
		static ButtonSound()
		{
			Il2CppClassPointerStore<ButtonSound>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "ButtonSound");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr);
			ButtonSound.NativeFieldInfoPtr_AudioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, "AudioSource");
			ButtonSound.NativeFieldInfoPtr_EventTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, "EventTrigger");
			ButtonSound.NativeFieldInfoPtr_HoverClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, "HoverClip");
			ButtonSound.NativeFieldInfoPtr_HoverSoundVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, "HoverSoundVolume");
			ButtonSound.NativeFieldInfoPtr_ClickClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, "ClickClip");
			ButtonSound.NativeFieldInfoPtr_ClickSoundVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, "ClickSoundVolume");
			ButtonSound.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, "Button");
			ButtonSound.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, 100676928);
			ButtonSound.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, 100676929);
			ButtonSound.NativeMethodInfoPtr_AddEventTrigger_Public_Void_EventTrigger_EventTriggerType_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, 100676930);
			ButtonSound.NativeMethodInfoPtr_Hovered_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, 100676931);
			ButtonSound.NativeMethodInfoPtr_Clicked_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, 100676932);
			ButtonSound.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, 100676933);
		}

		// Token: 0x06006BD9 RID: 27609 RVA: 0x001DFBB0 File Offset: 0x001DDDB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216220, XrefRangeEnd = 216235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonSound.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BDA RID: 27610 RVA: 0x001DFBE4 File Offset: 0x001DDDE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216235, XrefRangeEnd = 216250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonSound.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BDB RID: 27611 RVA: 0x001DFC18 File Offset: 0x001DDE18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 216272, RefRangeEnd = 216274, XrefRangeStart = 216250, XrefRangeEnd = 216272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddEventTrigger(EventTrigger eventTrigger, EventTriggerType eventTriggerType, Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventTrigger);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventTriggerType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonSound.NativeMethodInfoPtr_AddEventTrigger_Public_Void_EventTrigger_EventTriggerType_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BDC RID: 27612 RVA: 0x001DFC7C File Offset: 0x001DDE7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216274, XrefRangeEnd = 216275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ButtonSound.NativeMethodInfoPtr_Hovered_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BDD RID: 27613 RVA: 0x001DFCB8 File Offset: 0x001DDEB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216275, XrefRangeEnd = 216276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ButtonSound.NativeMethodInfoPtr_Clicked_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BDE RID: 27614 RVA: 0x001DFCF4 File Offset: 0x001DDEF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216276, XrefRangeEnd = 216277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ButtonSound() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonSound.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BDF RID: 27615 RVA: 0x00033097 File Offset: 0x00031297
		public ButtonSound(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700206C RID: 8300
		// (get) Token: 0x06006BE0 RID: 27616 RVA: 0x001DFD30 File Offset: 0x001DDF30
		// (set) Token: 0x06006BE1 RID: 27617 RVA: 0x000330A0 File Offset: 0x000312A0
		public unsafe AudioSourceController AudioSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr_AudioSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr_AudioSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700206D RID: 8301
		// (get) Token: 0x06006BE2 RID: 27618 RVA: 0x001DFD60 File Offset: 0x001DDF60
		// (set) Token: 0x06006BE3 RID: 27619 RVA: 0x000330BF File Offset: 0x000312BF
		public unsafe EventTrigger EventTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr_EventTrigger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventTrigger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr_EventTrigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700206E RID: 8302
		// (get) Token: 0x06006BE4 RID: 27620 RVA: 0x001DFD90 File Offset: 0x001DDF90
		// (set) Token: 0x06006BE5 RID: 27621 RVA: 0x000330DE File Offset: 0x000312DE
		public unsafe AudioClip HoverClip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr_HoverClip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr_HoverClip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700206F RID: 8303
		// (get) Token: 0x06006BE6 RID: 27622 RVA: 0x001DFDC0 File Offset: 0x001DDFC0
		// (set) Token: 0x06006BE7 RID: 27623 RVA: 0x000330FD File Offset: 0x000312FD
		public unsafe float HoverSoundVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr_HoverSoundVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr_HoverSoundVolume)) = value;
			}
		}

		// Token: 0x17002070 RID: 8304
		// (get) Token: 0x06006BE8 RID: 27624 RVA: 0x001DFDE8 File Offset: 0x001DDFE8
		// (set) Token: 0x06006BE9 RID: 27625 RVA: 0x00033118 File Offset: 0x00031318
		public unsafe AudioClip ClickClip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr_ClickClip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr_ClickClip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002071 RID: 8305
		// (get) Token: 0x06006BEA RID: 27626 RVA: 0x001DFE18 File Offset: 0x001DE018
		// (set) Token: 0x06006BEB RID: 27627 RVA: 0x00033137 File Offset: 0x00031337
		public unsafe float ClickSoundVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr_ClickSoundVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr_ClickSoundVolume)) = value;
			}
		}

		// Token: 0x17002072 RID: 8306
		// (get) Token: 0x06006BEC RID: 27628 RVA: 0x001DFE40 File Offset: 0x001DE040
		// (set) Token: 0x06006BED RID: 27629 RVA: 0x00033152 File Offset: 0x00031352
		public unsafe Button Button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr_Button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040049C6 RID: 18886
		private static readonly IntPtr NativeFieldInfoPtr_AudioSource;

		// Token: 0x040049C7 RID: 18887
		private static readonly IntPtr NativeFieldInfoPtr_EventTrigger;

		// Token: 0x040049C8 RID: 18888
		private static readonly IntPtr NativeFieldInfoPtr_HoverClip;

		// Token: 0x040049C9 RID: 18889
		private static readonly IntPtr NativeFieldInfoPtr_HoverSoundVolume;

		// Token: 0x040049CA RID: 18890
		private static readonly IntPtr NativeFieldInfoPtr_ClickClip;

		// Token: 0x040049CB RID: 18891
		private static readonly IntPtr NativeFieldInfoPtr_ClickSoundVolume;

		// Token: 0x040049CC RID: 18892
		private static readonly IntPtr NativeFieldInfoPtr_Button;

		// Token: 0x040049CD RID: 18893
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x040049CE RID: 18894
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x040049CF RID: 18895
		private static readonly IntPtr NativeMethodInfoPtr_AddEventTrigger_Public_Void_EventTrigger_EventTriggerType_Action_0;

		// Token: 0x040049D0 RID: 18896
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Protected_Virtual_New_Void_0;

		// Token: 0x040049D1 RID: 18897
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Protected_Virtual_New_Void_0;

		// Token: 0x040049D2 RID: 18898
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A5A RID: 2650
		[ObfuscatedName("ScheduleOne.Audio.ButtonSound+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D083 RID: 53379 RVA: 0x0031FFBC File Offset: 0x0031E1BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<ButtonSound.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonSound.__c__DisplayClass9_0>.NativeClassPtr);
				ButtonSound.__c__DisplayClass9_0.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonSound.__c__DisplayClass9_0>.NativeClassPtr, "action");
				ButtonSound.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonSound.__c__DisplayClass9_0>.NativeClassPtr, 100676934);
				ButtonSound.__c__DisplayClass9_0.NativeMethodInfoPtr__AddEventTrigger_b__0_Internal_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonSound.__c__DisplayClass9_0>.NativeClassPtr, 100676935);
			}

			// Token: 0x0600D084 RID: 53380 RVA: 0x00320024 File Offset: 0x0031E224
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ButtonSound.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonSound.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D085 RID: 53381 RVA: 0x00320060 File Offset: 0x0031E260
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _AddEventTrigger_b__0(BaseEventData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonSound.__c__DisplayClass9_0.NativeMethodInfoPtr__AddEventTrigger_b__0_Internal_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D086 RID: 53382 RVA: 0x00065834 File Offset: 0x00063A34
			public __c__DisplayClass9_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040C5 RID: 16581
			// (get) Token: 0x0600D087 RID: 53383 RVA: 0x003200A4 File Offset: 0x0031E2A4
			// (set) Token: 0x0600D088 RID: 53384 RVA: 0x0006583D File Offset: 0x00063A3D
			public unsafe Action action
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.__c__DisplayClass9_0.NativeFieldInfoPtr_action);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.__c__DisplayClass9_0.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008CBA RID: 36026
			private static readonly IntPtr NativeFieldInfoPtr_action;

			// Token: 0x04008CBB RID: 36027
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008CBC RID: 36028
			private static readonly IntPtr NativeMethodInfoPtr__AddEventTrigger_b__0_Internal_Void_BaseEventData_0;
		}
	}
}
